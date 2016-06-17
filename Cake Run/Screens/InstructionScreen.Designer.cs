namespace Cake_Run
{
    partial class InstructionScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.indicator1 = new System.Windows.Forms.Label();
            this.indicator2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // indicator1
            // 
            this.indicator1.BackColor = System.Drawing.Color.Red;
            this.indicator1.ForeColor = System.Drawing.SystemColors.Control;
            this.indicator1.Location = new System.Drawing.Point(271, 616);
            this.indicator1.Name = "indicator1";
            this.indicator1.Size = new System.Drawing.Size(80, 80);
            this.indicator1.TabIndex = 6;
            this.indicator1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // indicator2
            // 
            this.indicator2.BackColor = System.Drawing.Color.Red;
            this.indicator2.ForeColor = System.Drawing.SystemColors.Control;
            this.indicator2.Location = new System.Drawing.Point(470, 616);
            this.indicator2.Name = "indicator2";
            this.indicator2.Size = new System.Drawing.Size(80, 80);
            this.indicator2.TabIndex = 7;
            this.indicator2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InstructionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Cake_Run.Properties.Resources.InstructionScreen;
            this.ClientSize = new System.Drawing.Size(800, 750);
            this.Controls.Add(this.indicator2);
            this.Controls.Add(this.indicator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InstructionScreen";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InstructionScreen_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label indicator1;
        private System.Windows.Forms.Label indicator2;
    }
}

