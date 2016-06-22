///
/// Program Name:    Cake Run
/// 
/// Programmer       Joe Soukphachanh :)
/// 
/// Program Description:
/// 
/// Jump from one cloud-created object to the next. 
/// Each cloud has an assigned colour and the players have to press the correct button to get to the next cloud.
/// If the player presses the wrong cloud, they will be stunned temporarily and thus be unable to press any other buttons until the stun penalty has been released
/// Aftering reaching the end, the fastest time will be compared to the highscore and if the winning time is fast enough, NEW HIGHSCORE! :D
/// 
/// Buttons used:
/// 
///     Z
///     X
///     C
///     V
///     B
///     N
///     M
///     Space
///     Escape
/// 
/// Thanks to Mr. Theodoropulous (I hope I spelt your last name right!) for all the help given :D
/// 
/// Final Words for this program:
/// 
/// If I were to improve it, it needs to be faster. Perhaps the capabilities of the game is bottlenecked because of the performance the the computer it runs on
/// , but it is not a big game at all. So it should run blazingly fast and players should be able to blaze through all the clouds in perhaps half a minute or less!
/// 
/// I would also change the background picture of the game screen. I feel as if the objects in the game and the background do not work together. The cake at the end
/// needs to be like cartoon and the background has to feel happy. Perhaps a better way of saying this is: The background feels to realistic incomparison to the
/// cartoon-styled gameplay.
/// 
/// Next, is implementing intials to be used in the highscore so that a person can have the pride of having the fastest time! But atlas! I do not have the time to
/// do so.
/// 
/// Furthermore, I would include different songs instead of the same one everytime.
/// 
/// Finally, I would have also liked to have re-designed by instruction screen as I do not feel content with it. As well as, IT NEEDS TO BE FASTER; It's laggy. :x
/// 
/// Date of Program: Spring 2016


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

namespace Cake_Run
{
    public partial class InstructionScreen : Form
    {
        const int playersNeeded = 2;
        public static int playersCurrentlyReady = 0;
        public static Label leftIndicator, rightIndicator;

        public InstructionScreen()
        {
            InitializeComponent();
            this.Focus();
            Cursor.Hide();

            //To allow access from other user controls
            leftIndicator = indicator1;
            rightIndicator = indicator2;

            //Constructing a black background for the Rams Arcade
            Form bg = new Form();
            bg.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            bg.BackColor = Color.Black;
            bg.FormBorderStyle = FormBorderStyle.None;
            bg.SendToBack();
            bg.Show();

            //Alteration of labels to make them look like circles
            GraphicsPath circlePath = new GraphicsPath();
            circlePath.AddEllipse(0, 0, 80, 80);

            indicator1.Region = new Region(circlePath);
            indicator2.Region = new Region(circlePath);
        }

        private void InstructionScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    playersCurrentlyReady++;
                    indicator1.BackColor = Color.Green;
                    Refresh();
                    Check();
                    break;
                case Keys.Z:
                    playersCurrentlyReady++;
                    indicator2.BackColor = Color.Green;
                    Refresh();
                    Check();
                    break;
                case Keys.Escape:
                    PauseScreen a = new PauseScreen();
                    a.Show();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Checks if players are ready
        /// </summary>
        public void Check()
        {
            if (playersCurrentlyReady == playersNeeded)
            {
                GameScreen gs = new GameScreen();
                this.Controls.Add(gs);
                gs.BringToFront();
            }
        }
    }
}
