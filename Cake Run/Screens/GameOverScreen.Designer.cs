namespace Cake_Run
{
    partial class GameOverScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTitle1 = new System.Windows.Forms.Label();
            this.labelWinnerTitle = new System.Windows.Forms.Label();
            this.labelFastTime = new System.Windows.Forms.Label();
            this.labelHint = new System.Windows.Forms.Label();
            this.labelWinnerTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelNewHighscore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle1
            // 
            this.labelTitle1.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle1.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTitle1.Location = new System.Drawing.Point(0, 63);
            this.labelTitle1.Name = "labelTitle1";
            this.labelTitle1.Size = new System.Drawing.Size(800, 68);
            this.labelTitle1.TabIndex = 0;
            this.labelTitle1.Text = "Fastest Time";
            this.labelTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWinnerTitle
            // 
            this.labelWinnerTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelWinnerTitle.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWinnerTitle.ForeColor = System.Drawing.Color.Crimson;
            this.labelWinnerTitle.Location = new System.Drawing.Point(3, 273);
            this.labelWinnerTitle.Name = "labelWinnerTitle";
            this.labelWinnerTitle.Size = new System.Drawing.Size(800, 68);
            this.labelWinnerTitle.TabIndex = 1;
            this.labelWinnerTitle.Text = "Winner";
            this.labelWinnerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFastTime
            // 
            this.labelFastTime.BackColor = System.Drawing.Color.Transparent;
            this.labelFastTime.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFastTime.ForeColor = System.Drawing.Color.Khaki;
            this.labelFastTime.Location = new System.Drawing.Point(3, 117);
            this.labelFastTime.Name = "labelFastTime";
            this.labelFastTime.Size = new System.Drawing.Size(800, 68);
            this.labelFastTime.TabIndex = 3;
            this.labelFastTime.Text = "0000";
            this.labelFastTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHint
            // 
            this.labelHint.BackColor = System.Drawing.Color.Transparent;
            this.labelHint.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHint.ForeColor = System.Drawing.Color.Gray;
            this.labelHint.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.labelHint.Location = new System.Drawing.Point(0, 552);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(800, 82);
            this.labelHint.TabIndex = 4;
            this.labelHint.Text = "Score is in milliseconds\r\nPress RED to exit\r\nPress BLUE for a rematch\r\n";
            this.labelHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWinnerTime
            // 
            this.labelWinnerTime.BackColor = System.Drawing.Color.Transparent;
            this.labelWinnerTime.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWinnerTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelWinnerTime.Location = new System.Drawing.Point(3, 341);
            this.labelWinnerTime.Name = "labelWinnerTime";
            this.labelWinnerTime.Size = new System.Drawing.Size(800, 68);
            this.labelWinnerTime.TabIndex = 5;
            this.labelWinnerTime.Text = "0000";
            this.labelWinnerTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(614, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 100);
            this.label1.TabIndex = 9;
            this.label1.Text = "Exit?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 100);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rematch?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNewHighscore
            // 
            this.labelNewHighscore.BackColor = System.Drawing.Color.Transparent;
            this.labelNewHighscore.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewHighscore.ForeColor = System.Drawing.Color.Yellow;
            this.labelNewHighscore.Location = new System.Drawing.Point(3, 205);
            this.labelNewHighscore.Name = "labelNewHighscore";
            this.labelNewHighscore.Size = new System.Drawing.Size(800, 68);
            this.labelNewHighscore.TabIndex = 11;
            this.labelNewHighscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.labelNewHighscore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelWinnerTime);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.labelFastTime);
            this.Controls.Add(this.labelWinnerTitle);
            this.Controls.Add(this.labelTitle1);
            this.DoubleBuffered = true;
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(800, 750);
            this.Load += new System.EventHandler(this.GameOverScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameOverScreen_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameOverScreen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameOverScreen_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle1;
        private System.Windows.Forms.Label labelWinnerTitle;
        private System.Windows.Forms.Label labelFastTime;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.Label labelWinnerTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelNewHighscore;
    }
}
