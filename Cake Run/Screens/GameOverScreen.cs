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
    public partial class GameOverScreen : UserControl
    {
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void GameOverScreen_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(230, 10, 0, 0);
        }

        private void GameOverScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.V: // Blue
                    Form f = this.FindForm();
                    InstructionScreen iss = new InstructionScreen();
                    f.Controls.Remove(this);
                    f.Controls.Add(iss);
                    break;
                case Keys.B: // Blue

                    break;
                case Keys.X: // Red
                    Application.Exit();
                    break;
                case Keys.M: // Red
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void GameOverScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.V: // Blue
                    Form f = this.FindForm();
                    InstructionScreen iss = new InstructionScreen();
                    f.Controls.Remove(this);
                    f.Controls.Add(iss);
                    break;
                case Keys.B: // Blue

                    break;
                case Keys.X: // Red
                    Application.Exit();
                    break;
                case Keys.M: // Red
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
    }
}
