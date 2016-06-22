using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cake_Run
{
    public partial class PauseScreen : Form
    {
        public PauseScreen()
        {
            InitializeComponent();
            Cursor.Hide();
        }

        private void PauseScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Z:
                    Close();
                    break;
                case Keys.Space:
                    Close();
                    break;
                case Keys.M:
                    Application.Exit();
                    break;
                case Keys.X:
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
    }
}
