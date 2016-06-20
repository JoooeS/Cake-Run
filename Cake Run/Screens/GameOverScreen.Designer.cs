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
            this.labelTitle1 = new System.Windows.Forms.Label();
            this.labelPlayer1Title = new System.Windows.Forms.Label();
            this.labelPlayer2Title = new System.Windows.Forms.Label();
            this.labelFastTime = new System.Windows.Forms.Label();
            this.labelHint = new System.Windows.Forms.Label();
            this.labelPlayer1Time = new System.Windows.Forms.Label();
            this.labelPlayer2Time = new System.Windows.Forms.Label();
            this.buttonRematch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // labelPlayer1Title
            // 
            this.labelPlayer1Title.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer1Title.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1Title.ForeColor = System.Drawing.Color.Crimson;
            this.labelPlayer1Title.Location = new System.Drawing.Point(0, 288);
            this.labelPlayer1Title.Name = "labelPlayer1Title";
            this.labelPlayer1Title.Size = new System.Drawing.Size(800, 68);
            this.labelPlayer1Title.TabIndex = 1;
            this.labelPlayer1Title.Text = "Player 1 Time";
            this.labelPlayer1Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlayer2Title
            // 
            this.labelPlayer2Title.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer2Title.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer2Title.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelPlayer2Title.Location = new System.Drawing.Point(0, 428);
            this.labelPlayer2Title.Name = "labelPlayer2Title";
            this.labelPlayer2Title.Size = new System.Drawing.Size(800, 68);
            this.labelPlayer2Title.TabIndex = 2;
            this.labelPlayer2Title.Text = "Player 2 Time";
            this.labelPlayer2Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFastTime
            // 
            this.labelFastTime.BackColor = System.Drawing.Color.Transparent;
            this.labelFastTime.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFastTime.ForeColor = System.Drawing.Color.Yellow;
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
            this.labelHint.Location = new System.Drawing.Point(3, 589);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(800, 68);
            this.labelHint.TabIndex = 4;
            this.labelHint.Text = "Score is in milliseconds";
            this.labelHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlayer1Time
            // 
            this.labelPlayer1Time.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer1Time.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer1Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelPlayer1Time.Location = new System.Drawing.Point(3, 341);
            this.labelPlayer1Time.Name = "labelPlayer1Time";
            this.labelPlayer1Time.Size = new System.Drawing.Size(800, 68);
            this.labelPlayer1Time.TabIndex = 5;
            this.labelPlayer1Time.Text = "0000";
            this.labelPlayer1Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlayer2Time
            // 
            this.labelPlayer2Time.BackColor = System.Drawing.Color.Transparent;
            this.labelPlayer2Time.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer2Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelPlayer2Time.Location = new System.Drawing.Point(3, 484);
            this.labelPlayer2Time.Name = "labelPlayer2Time";
            this.labelPlayer2Time.Size = new System.Drawing.Size(800, 68);
            this.labelPlayer2Time.TabIndex = 6;
            this.labelPlayer2Time.Text = "0000";
            this.labelPlayer2Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRematch
            // 
            this.buttonRematch.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonRematch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRematch.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRematch.Location = new System.Drawing.Point(35, 528);
            this.buttonRematch.Name = "buttonRematch";
            this.buttonRematch.Size = new System.Drawing.Size(140, 100);
            this.buttonRematch.TabIndex = 7;
            this.buttonRematch.Text = "Rematch?";
            this.buttonRematch.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(607, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 100);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit?";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRematch);
            this.Controls.Add(this.labelPlayer2Time);
            this.Controls.Add(this.labelPlayer1Time);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.labelFastTime);
            this.Controls.Add(this.labelPlayer2Title);
            this.Controls.Add(this.labelPlayer1Title);
            this.Controls.Add(this.labelTitle1);
            this.DoubleBuffered = true;
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(800, 750);
            this.Load += new System.EventHandler(this.GameOverScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameOverScreen_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameOverScreen_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle1;
        private System.Windows.Forms.Label labelPlayer1Title;
        private System.Windows.Forms.Label labelPlayer2Title;
        private System.Windows.Forms.Label labelFastTime;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.Label labelPlayer1Time;
        private System.Windows.Forms.Label labelPlayer2Time;
        private System.Windows.Forms.Button buttonRematch;
        private System.Windows.Forms.Button button1;
    }
}
