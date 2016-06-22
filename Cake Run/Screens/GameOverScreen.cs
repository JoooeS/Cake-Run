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
using System.Xml;
using System.Diagnostics;

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
            this.Focus();
            this.BackColor = Color.FromArgb(0, 0, 0);
            this.BringToFront();
            labelWinnerTime.Text = Convert.ToString(GameScreen.playerTime.ElapsedMilliseconds);
            labelWinnerTitle.Text = GameScreen.winner;

            InstructionScreen.playersCurrentlyReady = 0;
            InstructionScreen.leftIndicator.BackColor = Color.Red;
            InstructionScreen.rightIndicator.BackColor = Color.Red;

            Read();

            if (Convert.ToInt32(labelWinnerTime.Text) < Convert.ToInt32(labelFastTime.Text))
            {
                labelNewHighscore.Text = "NEW HIGHSCORE!";
            }
        }

        /// <summary>
        /// Opens highscore XML and reads highscore
        /// </summary>
        private void Read()
        {
            XmlTextReader reader = new XmlTextReader("highscore.xml");

            labelFastTime.Text = "";

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                   labelFastTime.Text = reader.Value;
                }
            }
            Refresh();
            Thread.Sleep(2000);

            reader.Close();
        }
        
        /// <summary>
        /// Checks wheter a new highscore has been made and saves the fastest time as the highscore
        /// </summary>
        private void Write()
        {
            XmlTextWriter writer = new XmlTextWriter("highscore.xml", null);

            writer.WriteStartElement("highscore");

            if (Convert.ToInt32(labelWinnerTime.Text) < Convert.ToInt32(labelFastTime.Text))
            {
                writer.WriteElementString("score", Convert.ToString(labelWinnerTime.Text));
            }
            else
            {
                writer.WriteElementString("score", Convert.ToString(labelFastTime.Text));
            }            

            writer.WriteEndElement();

            writer.Close();
        }

        private void GameOverScreen_KeyUp(object sender, KeyEventArgs e)
        {
            Form f = this.FindForm();

            switch (e.KeyCode)
            {
                case Keys.V: // Blue
                    Write();
                    f.Controls.Remove(this);
                    break;
                case Keys.B: // Blue
                    Write();
                    f.Controls.Remove(this);
                    break;
                case Keys.X: // Red
                    Write();
                    Application.Exit();
                    break;
                case Keys.M: // Red
                    Write();
                    Application.Exit();
                    break;
                case Keys.Escape:
                    PauseScreen a = new PauseScreen();
                    a.Show();
                    break;
                default:
                    break;
            }
        }

        private void GameOverScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.Crown, 280, 283, 40, 40);
        }
    }
}
