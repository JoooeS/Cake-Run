///
/// Program Name: Race for the Cake
/// Programmer: Joe Soukphachanh
/// Program Description: Jump from one cloud-created object to the next. Each cloud has an assigned colour and the players have to press the correct button
/// to get to the next cloud. If the player presses the wrong cloud, they will be stunned temporrary and thus be unable to press any other buttons until the
/// stun penalty has been released
/// 
/// Date: Spring 2016


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
        const int PLAYERS_NEEDED_TO_BE_READY = 2;
        public static int playersCurrentlyReady = 0;
        public static Label leftIndicator, rightIndicator;

        public InstructionScreen()
        {
            InitializeComponent();

            leftIndicator = indicator1;
            rightIndicator = indicator2;

            Form bg = new Form();
            bg.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            bg.BackColor = Color.Black;
            bg.FormBorderStyle = FormBorderStyle.None;
            bg.SendToBack();
            bg.Show();

            this.Focus();
            Cursor.Hide();

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
            if (playersCurrentlyReady == PLAYERS_NEEDED_TO_BE_READY)
            {
                GameScreen gs = new GameScreen();
                this.Controls.Add(gs);
                gs.BringToFront();
            }
        }
    }
}
