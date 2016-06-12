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

namespace Cake_Run
{
    public partial class GameScreen : UserControl
    {
        #region Variables
        int LINE_RATIO = 5; //Add 5 everytime they go up a cloud and the progression circle needs to move CONSTANT

        int CLOUD_Y_SIZE = 30; //Accounts for height CONSTANT
        int CLOUD_X_SIZE = 40; //TESTING STILL
        int CLOUD_Y_SPACING = 5; //ACounts for the height spacing between clouds
        int CLOUD_X_SPACING = 40; //TESTING STILL
        int player1PictureLocation = -750;
        int player2PictureLocation = -750;

        //player1 button control keys 
        Boolean bDown, nDown, mDown, spaceDown;

        //player2 button control keys 
        Boolean cDown, vDown, xDown, zDown; //Y<R<G<Y

        Random numberGen = new Random();

        Image[] cloudColours = new Image[4];
        List<int> colourPattern = new List<int>();
        List<Cloud> p1Clouds = new List<Cloud>();
        List<Cloud> p2Clouds = new List<Cloud>();

        Character player1;
        Character player2;
        #endregion

        public GameScreen()
        {
            InitializeComponent();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {
            //TODO Count down


            //ff
            cloudColours[0] = Properties.Resources.redCloud;
            cloudColours[1] = Properties.Resources.greenCloud;
            cloudColours[2] = Properties.Resources.yellowCloud;
            cloudColours[3] = Properties.Resources.blueCloud;

            //Create colour pattern which will be the same for both characters for fairness
            for (int i = 0; i < 40; i++)
            {
                int x = numberGen.Next(0, 4);

                colourPattern.Add(x);
            }

            this.Focus();

            //Player 1 clouds
            for (int i = 0; i < 40; i++)
            {
                Cloud c = new Cloud(colourPattern[i], numberGen.Next(10, 250), 550 - (40 * i), CLOUD_X_SIZE, CLOUD_Y_SIZE, cloudColours[colourPattern[i]]);
                p1Clouds.Add(c);
            }

            //Player 2 clouds
            for (int i = 0; i < 40; i++)
            {
                Cloud c = new Cloud(colourPattern[i], numberGen.Next(510, 750), 550 - (40 * i), CLOUD_X_SIZE, CLOUD_Y_SIZE, cloudColours[colourPattern[i]]);
                p2Clouds.Add(c);
            }

            player1 = new Character(p1Clouds[0].xLoc, p1Clouds[0].yLoc + 50, 40, 30, 0, Properties.Resources.playerCloud);
            player2 = new Character(p2Clouds[0].xLoc, p2Clouds[0].yLoc + 50, 40, 30, 0, Properties.Resources.playerCloud);


            gameTick.Enabled = true;
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            // Background images
                // PLAYER ONE - LEFT
            
                //PLAYER TWO - RIGHT
            e.Graphics.DrawImage(Properties.Resources.Sky, 398, player2PictureLocation);

                //MIDDLE LINE
            e.Graphics.DrawLine(new Pen(Color.LightBlue, 12), 394, 0, 394, 750);
                //MIDDLE RECTANGLE
            e.Graphics.DrawRectangle(new Pen(Color.LightBlue, 8), 300, 260, 200, 280);
            e.Graphics.FillRectangle(new SolidBrush(Color.LightYellow), 304, 264, 192, 272);

                // PROGRESS LINE AND BAR
            e.Graphics.DrawLine(new Pen(Color.Black, 4), 348, 312, 348, 512);
            e.Graphics.DrawLine(new Pen(Color.Black, 4), 448, 312, 448, 512);
            e.Graphics.DrawString("GOAL", new Font("Verdana", 24, FontStyle.Regular), new SolidBrush(Color.DarkOrange), 350, 270);

                // TWO CIRCLES FOR PLAYER ONE AND PLAYER TWO
            e.Graphics.FillEllipse(new SolidBrush(Color.LightBlue), 337, 500 - (player1.cloudsCleared * LINE_RATIO), 22, 22); // Player Left
            e.Graphics.FillEllipse(new SolidBrush(Color.LightGreen), 437, 500 - (player2.cloudsCleared * LINE_RATIO), 22, 22); /// Player Right

                //DRAW ALL CLOUDS FOR PLAYER ONE
            foreach (var c in p1Clouds)
            {
                e.Graphics.DrawImage(c.cloudColour, c.xLoc, c.yLoc + (50 * player1.cloudsCleared), c.xSize, c.ySize);
            }

                //DRAW ALL CLOUDS FOR PLAYER TWO
            foreach (var c in p2Clouds)
            {
                e.Graphics.DrawImage(c.cloudColour, c.xLoc, c.yLoc + (50 * player2.cloudsCleared), c.xSize, c.ySize);
            }

            //DRAWING PLAYER ONE AND PLAYER TWO RESPECTIVELY:
            e.Graphics.DrawImage(player1.playerCloud, player1.xLoc, player1.yLoc, player1.xSize, player1.ySize);
            e.Graphics.DrawImage(player2.playerCloud, player2.xLoc, player2.yLoc, player2.xSize, player2.ySize);
        }

        private void gameTick_Tick(object sender, EventArgs e)
        {
            if (player1.cloudsCleared <= 25)
            {
                player1PictureLocation = -750 + (player1.cloudsCleared * 30);
            }
            else if (player1.cloudsCleared > 25)
            {
                player1PictureLocation = 0;
            }

            if (player2.cloudsCleared <= 25)
            {
                player2PictureLocation = -750 + (player2.cloudsCleared * 30);
            }
            else if (player2.cloudsCleared > 25)
            {
                player2PictureLocation = 0;
            }

            Refresh();
        }

        private void ColourCheck(Character p, int colour, List<Cloud> playerList)
        {
            if (p.cloudsCleared < 40)
            {
                if (colour == playerList[0].colour)
                {
                    p.cloudsCleared++;

                    p.xLoc = playerList[0].xLoc + (50 * p.cloudsCleared);
                    p.yLoc = playerList[0].yLoc + (50 * p.cloudsCleared);
                    playerList.RemoveAt(0);

                    Refresh();
                }
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode)
            {
                //PLAYER 2 RIGHT
                case Keys.B:
                    bDown = true;   //BLUE
                    ColourCheck(player2, 3, p2Clouds);

                    break;
                case Keys.N:
                    nDown = true;   //YELLOW
                    ColourCheck(player2, 2, p2Clouds);

                    break;
                case Keys.M:
                    mDown = true;   //RED
                    ColourCheck(player2, 0, p2Clouds);

                    break;
                case Keys.Space:
                    spaceDown = true;   //GREEN
                    ColourCheck(player2, 1, p2Clouds);

                    break;


                // PLAYER 1 LEFT
                case Keys.V:
                    vDown = true;
                    ColourCheck(player1, 3, p1Clouds);

                    break;
                case Keys.C:
                    cDown = true;
                    ColourCheck(player1, 2, p1Clouds);

                    break;
                case Keys.X:
                    xDown = true;
                    ColourCheck(player1, 0, p1Clouds);

                    break;
                case Keys.Z:
                    zDown = true;
                    ColourCheck(player1, 1, p1Clouds);

                    break;
                default:
                    break;
            }
        }

        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //PLAYER 2 RIGHT
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

                // PLAYER 1 LEFT
                case Keys.V:
                    vDown = false;
                    break;
                case Keys.C:
                    cDown = false;
                    break;
                case Keys.X:
                    xDown = false;
                    break;
                case Keys.Z:
                    zDown = false;
                    break;

                default:
                    break;
            }
        }
    }
}
