using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WMPLib;
using System.Diagnostics;

namespace Cake_Run
{
    public partial class GameScreen : UserControl
    {
        #region Variables
        //Values related to imaging and graphics
        int lineRatio = 3;
        int CLOUD_Y_SIZE = 30;
        int CLOUD_X_SIZE = 40;
        int numberOfClouds = 67;
        int player1PictureLocation = -750;
        int player2PictureLocation = -750;
        int animateTime = 4;
        int endOfGameTime;
        int winX = 200;
        int loseX = 200;

        public static string winner;
        public static Stopwatch playerTime;

        //Random number generator for colour pattern creation
        Random numberGen = new Random();

        //Booleans to send values for when a button has been pressed
        bool bDown, nDown, mDown, spaceDown, zDown, xDown, cDown, vDown;
        bool endOfGame = false;

        //Clouds
        Image[] cloudColours = new Image[4];

        //Lists
        List<int> colourPattern = new List<int>();
        List<Cloud> p1Clouds = new List<Cloud>();
        List<Cloud> p2Clouds = new List<Cloud>();        

        //Player classes
        Character player1;
        Character player2;

        //MP3 Players
        WindowsMediaPlayer songPlayer = new WindowsMediaPlayer();
        WindowsMediaPlayer yayplayer = new WindowsMediaPlayer();
        WindowsMediaPlayer jumpPlayer = new WindowsMediaPlayer();
        WindowsMediaPlayer jumpPlayer2 = new WindowsMediaPlayer();
        WindowsMediaPlayer jumpPlayer3 = new WindowsMediaPlayer();
        WindowsMediaPlayer jumpPlayer4 = new WindowsMediaPlayer();
        WindowsMediaPlayer jumpPlayer5 = new WindowsMediaPlayer();
        WindowsMediaPlayer jumpPlayer6 = new WindowsMediaPlayer();
        
        //To allow for multiple "jumpplayer"s to be played over top one another
        Boolean jumpPlayerPlaying = false;
        Boolean jumpPlayerPlaying2 = false;
        Boolean jumpPlayerPlaying3 = false;
        Boolean jumpPlayerPlaying4 = false;
        Boolean jumpPlayerPlaying5 = false;
        Boolean jumpPlayerPlaying6 = false;
        #endregion

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            this.Focus();

            #region MP3 Players
            songPlayer.URL = "bensound-cute.mp3";
            jumpPlayer.URL = "Ya.mp3";
            jumpPlayer.controls.stop();
            jumpPlayer2.URL = "Ya.mp3";
            jumpPlayer2.controls.stop();
            jumpPlayer3.URL = "Ya.mp3";
            jumpPlayer3.controls.stop();
            jumpPlayer4.URL = "Ya.mp3";
            jumpPlayer4.controls.stop();
            jumpPlayer5.URL = "Ya.mp3";
            jumpPlayer5.controls.stop();
            jumpPlayer6.URL = "Ya.mp3";
            jumpPlayer6.controls.stop();
            yayplayer.URL = "yay.mp3";
            yayplayer.controls.stop();
            songPlayer.controls.play();
            #endregion

            //Array of Cloud Images
            cloudColours[0] = Properties.Resources.redCloud;
            cloudColours[1] = Properties.Resources.greenCloud;
            cloudColours[2] = Properties.Resources.yellowCloud;
            cloudColours[3] = Properties.Resources.blueCloud;

            //Create ONE coloured pattern to be used by both players
            for (int i = 0; i < numberOfClouds; i++)
            {
                int x = numberGen.Next(0, 4);
                colourPattern.Add(x);
            }

            //Player 1 clouds
            for (int i = 0; i < numberOfClouds; i++)
            {
                Cloud c = new Cloud(colourPattern[i], numberGen.Next(10, 250), 550 - (40 * i), CLOUD_X_SIZE, CLOUD_Y_SIZE, cloudColours[colourPattern[i]]);
                p1Clouds.Add(c);
            }

            //Player 2 clouds
            for (int i = 0; i < numberOfClouds; i++)
            {
                Cloud c = new Cloud(colourPattern[i], numberGen.Next(510, 750), 550 - (40 * i), CLOUD_X_SIZE, CLOUD_Y_SIZE, cloudColours[colourPattern[i]]);
                p2Clouds.Add(c);
            }

            //Creating player clouds
            player1 = new Character(numberGen.Next(10, 250), p1Clouds[0].yLoc + 50, 40, 30, 0, 0, 0, 0, Properties.Resources.playerCloud);
            player2 = new Character(numberGen.Next(510, 750), p2Clouds[0].yLoc + 50, 40, 30, 0, 0, 0, 0, Properties.Resources.playerCloud);
                        
            //Timer to record the winning time
            playerTime = new Stopwatch();
            playerTime.Start();

            //Start the tick method
            gameTick.Enabled = true;
        }

        private void gameTick_Tick(object sender, EventArgs e)
        {
            #region Player 2 check
            if (player2.cloudsCleared < numberOfClouds)
            {
                if (player2.errorCount == 0 & player2.animate == 0)
                {   // R = 0        G = 1            Y = 2           B = 3
                    if (zDown == true & p2Clouds[0].colour == 1)
                    {
                        player2.animate = animateTime;
                        player2.xDifference = player2.xLoc - p2Clouds[0].xLoc;
                    }
                    else if (zDown == true & p2Clouds[0].colour != 1)
                    {
                        player2.playerCloud = Properties.Resources.blackCloud;
                        player2.errorCount = 10;
                    }

                    if (xDown == true & p2Clouds[0].colour == 0)
                    {
                        player2.animate = animateTime;
                        player2.xDifference = player2.xLoc - p2Clouds[0].xLoc;
                    }
                    else if (xDown == true & p2Clouds[0].colour != 0)
                    {
                        player2.playerCloud = Properties.Resources.blackCloud;
                        player2.errorCount = 10;
                    }

                    if (cDown == true & p2Clouds[0].colour == 3)
                    {
                        player2.animate = animateTime;
                        player2.xDifference = player2.xLoc - p2Clouds[0].xLoc;
                    }
                    else if (cDown == true & p2Clouds[0].colour != 3)
                    {
                        player2.playerCloud = Properties.Resources.blackCloud;
                        player2.errorCount = 10;
                    }

                    if (vDown == true & p2Clouds[0].colour == 2)
                    {
                        player2.animate = animateTime;
                        player2.xDifference = player2.xLoc - p2Clouds[0].xLoc;
                    }
                    else if (vDown == true & p2Clouds[0].colour != 2)
                    {
                        player2.playerCloud = Properties.Resources.blackCloud;
                        player2.errorCount = 10;
                    }
                }
            }
            #endregion

            #region Player 1 check
            if (player1.cloudsCleared < numberOfClouds)
            {
                if (player1.errorCount == 0 & player1.animate == 0)
                {   // R = 0        G = 1            Y = 2           B = 3
                    if (bDown == true & p1Clouds[0].colour == 3)
                    {
                        player1.animate = animateTime;
                        player1.xDifference = player1.xLoc - p1Clouds[0].xLoc;

                    }
                    else if (bDown == true & p1Clouds[0].colour != 3)
                    {
                        player1.playerCloud = Properties.Resources.blackCloud;
                        player1.errorCount = 10;
                    }

                    if (nDown == true & p1Clouds[0].colour == 2)
                    {
                        player1.animate = animateTime;
                        player1.xDifference = player1.xLoc - p1Clouds[0].xLoc;
                    }
                    else if (nDown == true & p1Clouds[0].colour != 2)
                    {
                        player1.playerCloud = Properties.Resources.blackCloud;
                        player1.errorCount = 10;
                    }

                    if (mDown == true & p1Clouds[0].colour == 0)
                    {
                        player1.animate = animateTime;
                        player1.xDifference = player1.xLoc - p1Clouds[0].xLoc;
                    }
                    else if (mDown == true & p1Clouds[0].colour != 0)
                    {
                        player1.playerCloud = Properties.Resources.blackCloud;
                        player1.errorCount = 10;
                    }

                    if (spaceDown == true & p1Clouds[0].colour == 1)
                    {
                        player1.animate = animateTime;
                        player1.xDifference = player1.xLoc - p1Clouds[0].xLoc;
                    }
                    else if (spaceDown == true & p1Clouds[0].colour != 1)
                    {
                        player1.playerCloud = Properties.Resources.blackCloud;
                        player1.errorCount = 10;
                    }
                }
            }
            #endregion

            #region Animate check
            // Player 1 (left)
            if (player1.animate == 4)
            {
                if (!jumpPlayerPlaying)
                {
                    jumpPlayer.controls.play();
                    jumpPlayerPlaying = true;
                    jumpPlayerPlaying2 = false;
                }
                else if (!jumpPlayerPlaying2)
                {
                    jumpPlayer2.controls.play();
                    jumpPlayerPlaying2 = true;
                    jumpPlayerPlaying3 = false;
                }
                else if (!jumpPlayerPlaying3)
                {
                    jumpPlayer3.controls.play();
                    jumpPlayerPlaying3 = true;
                    jumpPlayerPlaying = false;
                }
            }
            if (player1.animate > 0)
            {
                player1PictureLocation += 3;
                player1.yLoc -= 2;

                if (player1.xDifference < 0)
                {
                    player1.xLoc += (player1.xDifference * -1) / 3;
                }
                else if (player1.xDifference > 0)
                {
                    player1.xLoc -= player1.xDifference / 3;
                }
                else if (player1.xDifference == 0)
                {
                    player1.xLoc = p1Clouds[0].xLoc;
                }

                foreach (var c in p1Clouds)
                {
                    c.yLoc += 11;
                }

                player1.animate--;
            }
            if (player1.animate == 1)
            {
                p1Clouds.RemoveAt(0);
                player1.cloudsCleared++;
                player1.animate--;
            }

            // Player 2 (right)
            if (player2.animate == 4)
            {
                if (!jumpPlayerPlaying4)
                {
                    jumpPlayer4.controls.play();
                    jumpPlayerPlaying4 = true;
                    jumpPlayerPlaying5 = false;
                }
                else if (!jumpPlayerPlaying5)
                {
                    jumpPlayer5.controls.play();
                    jumpPlayerPlaying5 = true;
                    jumpPlayerPlaying6 = false;
                }
                else if (!jumpPlayerPlaying6)
                {
                    jumpPlayer6.controls.play();
                    jumpPlayerPlaying6 = true;
                    jumpPlayerPlaying4 = false;
                }
            }
            if (player2.animate == 4)
            {
                jumpPlayer2.controls.play();
            }
            if (player2.animate > 0)
            {
                player2PictureLocation += 3;
                player2.yLoc -= 2;

                if (player2.xDifference < 0)
                {
                    player2.xLoc += (player2.xDifference * -1) / 3;
                }
                else if (player2.xDifference > 0)
                {
                    player2.xLoc -= player2.xDifference / 3;
                }
                else if (player2.xDifference == 0)
                {
                    player2.xLoc = p2Clouds[0].xLoc;
                }

                foreach (var c in p2Clouds)
                {
                    c.yLoc += 11;
                }

                player2.animate--;
            }
            if (player2.animate == 1)
            {
                p2Clouds.RemoveAt(0);
                player2.cloudsCleared++;
                player2.animate--;
            }
            #endregion

            #region ErrorCount check
            // Player 1 (left)
            if (player1.errorCount > 0 & player1.errorCount % 2 == 0)
            {
                player1PictureLocation += 6;
                player1.xLoc += 4;
                player1.errorCount--;
            }
            else if (player1.errorCount > 0 & player1.errorCount % 2 != 0)
            {
                player1PictureLocation -= 6;
                player1.xLoc -= 4;
                player1.errorCount--;
            }
            else if (player1.errorCount <= 0)
            {
                player1.playerCloud = Properties.Resources.playerCloud;
            }

            // Player 2 (right)
            if (player2.errorCount > 0 & player2.errorCount % 2 == 0)
            {
                player2PictureLocation += 6;
                player2.xLoc += 4;
                player2.errorCount--;
            }
            else if (player2.errorCount > 0 & player2.errorCount % 2 != 0)
            {
                player2PictureLocation -= 6;
                player2.xLoc -= 4;
                player2.errorCount--;
            }
            else if (player2.errorCount <= 0)
            {
                player2.playerCloud = Properties.Resources.playerCloud;
            }
            #endregion

            #region Win check
            if (player1.cloudsCleared == numberOfClouds || player2.cloudsCleared == numberOfClouds)
            {
                playerTime.Stop();
                if (player1.cloudsCleared == numberOfClouds)
                {
                    winner = "Player 1";
                }
                if (player2.cloudsCleared == numberOfClouds)
                {
                    winner = "Player 2";
                }

                if (endOfGameTime == 0 & endOfGame == false)
                {
                    yayplayer.controls.play();
                    endOfGame = true;
                    endOfGameTime = 93;
                }
                else if (endOfGameTime > 73)
                {
                    endOfGameTime--;
                }
                else if (endOfGameTime == 1)
                {
                    gameTick.Enabled = false;
                    gameTick.Stop();
                    Form f = this.FindForm();
                    f.Controls.Remove(this);
                    GameOverScreen gos = new GameOverScreen();
                    //this.BringToFront();
                    f.Controls.Add(gos);
                    gos.BringToFront();
                    
                }
                else if (winner == "Player 1")
                {
                    winX -= 3;
                    loseX += 3;
                    endOfGameTime--;
                }
                else if (winner == "Player 2")
                {
                    winX += 3;
                    loseX -= 3;
                    endOfGameTime--;
                }
            }



            #endregion

            Refresh();
        }

        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                // Player 1 (left)
                case Keys.V:
                    vDown = true;
                    break;
                case Keys.X:
                    xDown = true;
                    break;
                case Keys.C:
                    cDown = true;
                    break;
                case Keys.Z:
                    zDown = true;
                    break;

                // Player 2 (right)
                case Keys.B:
                    bDown = true;
                    break;
                case Keys.N:
                    nDown = true;
                    break;
                case Keys.M:
                    mDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;

                default:
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                // Player 2 - right
                case Keys.V:
                    vDown = false;
                    break;
                case Keys.X:
                    xDown = false;
                    break;
                case Keys.C:
                    cDown = false;
                    break;
                case Keys.Z:
                    zDown = false;
                    break;

                // Player 1 - left
                case Keys.B:
                    bDown = false;
                    break;
                case Keys.N:
                    nDown = false;
                    break;
                case Keys.M:
                    mDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;

                case Keys.Escape:
                    PauseScreen a = new PauseScreen();
                    a.Show();
                    break;
                default:
                    break;
            }
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //Background images
            e.Graphics.DrawImage(Properties.Resources.Sky, 0, player1PictureLocation, 398, 1500);
            e.Graphics.DrawImage(Properties.Resources.Sky, 398, player2PictureLocation, 402, 1500);

            //MIDDLE LINE
            e.Graphics.DrawLine(new Pen(Color.LightBlue, 12), 394, 0, 394, 750);
            //MIDDLE RECTANGLE
            e.Graphics.DrawRectangle(new Pen(Color.LightBlue, 8), 300, 260, 200, 280);
            e.Graphics.FillRectangle(new SolidBrush(Color.LightYellow), 304, 264, 192, 272);

            //PROGRESS LINE AND BAR
            e.Graphics.DrawLine(new Pen(Color.Black, 4), 348, 312, 348, 512);
            e.Graphics.DrawLine(new Pen(Color.Black, 4), 448, 312, 448, 512);
            e.Graphics.DrawString("GOAL", new Font("Verdana", 24, FontStyle.Regular), new SolidBrush(Color.DarkOrange), 350, 270);

            //TWO CIRCLES FOR PLAYER ONE AND PLAYER TWO
            e.Graphics.FillEllipse(new SolidBrush(Color.LightBlue), 337, 500 - (player1.cloudsCleared * lineRatio), 22, 22);
            e.Graphics.FillEllipse(new SolidBrush(Color.LightGreen), 437, 500 - (player2.cloudsCleared * lineRatio), 22, 22);

            //Daw all clouds for player 1
            foreach (var c in p1Clouds)
            {
                e.Graphics.DrawImage(c.cloudColour, c.xLoc, c.yLoc, c.xSize, c.ySize);
            }

            //Draw all clouds for player 2
            foreach (var c in p2Clouds)
            {
                e.Graphics.DrawImage(c.cloudColour, c.xLoc, c.yLoc, c.xSize, c.ySize);
            }

            //Drawing the actual cloud of each player
            e.Graphics.DrawImage(player1.playerCloud, player1.xLoc, player1.yLoc, player1.xSize, player1.ySize);
            e.Graphics.DrawImage(player2.playerCloud, player2.xLoc, player2.yLoc, player2.xSize, player2.ySize);

            //Win
            if (endOfGame)
            {
                e.Graphics.DrawImage(Properties.Resources.win, winX, 150, 400, 200);
                e.Graphics.DrawImage(Properties.Resources.lose, loseX, 350, 400, 200);
            }
        }
    }
}