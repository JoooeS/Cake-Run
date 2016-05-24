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
        int playersCurrentlyReady = 0;

        public InstructionScreen()
        {
            InitializeComponent();

            labelTitleDescription.BackColor = Color.FromArgb(240, 255, 0, 255);
            labelTitleInstruction.BackColor = Color.FromArgb(240, 0, 255, 0);
            labelFiller.BackColor = Color.FromArgb(240, 0, 80, 80);
            labelDescDetails.BackColor = labelInstrDetails.BackColor = Color.FromArgb(240, 0, 0, 0);
            labelBlack.BackColor = Color.FromArgb(0, 0, 0, 0);

            GraphicsPath circlePath = new GraphicsPath();
            circlePath.AddEllipse(0, 0, 80, 80);

            indicator1.Region = new Region(circlePath);
            indicator2.Region = new Region(circlePath);
            indicator3.Region = new Region(circlePath);
            indicator4.Region = new Region(circlePath);
        }

        private void InstructionScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.X:
                    playersCurrentlyReady++;
                    indicator1.BackColor = Color.Green;
                    Refresh();
                    Check();
                    break;
                case Keys.M:
                    playersCurrentlyReady++;
                    indicator2.BackColor = Color.Green;
                    Refresh();
                    Check();
                    break;
                default:
                    break;
            }
        }

        public void Check()
        {
            if (playersCurrentlyReady == PLAYERS_NEEDED_TO_BE_READY)
            {
                labelBlack.Visible = true;
                labelBlack.BackColor = Color.FromArgb(0, 0, 0, 0);
                labelBlack.BringToFront();
                Refresh();

                for (int i = 0; i < 256; i+= 8)
                {
                    labelBlack.BackColor = Color.FromArgb(i, 0, 0, 0);
                    labelBlack.Refresh();
                    Thread.Sleep(10);
                }


                GameScreen gs = new GameScreen();
                this.Controls.Add(gs);
                gs.BringToFront();
            }
        }
    }
}
