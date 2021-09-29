namespace GuessingNumberGameUpdate
{
    partial class FrmGuessingNumberGameUpdate
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
            this.BtnCheckGuess = new System.Windows.Forms.Button();
            this.BtnPickShowNumber = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnnumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCheckGuess
            // 
            this.BtnCheckGuess.Location = new System.Drawing.Point(130, 207);
            this.BtnCheckGuess.Name = "BtnCheckGuess";
            this.BtnCheckGuess.Size = new System.Drawing.Size(92, 23);
            this.BtnCheckGuess.TabIndex = 0;
            this.BtnCheckGuess.Text = "Check Guess";
            this.BtnCheckGuess.UseVisualStyleBackColor = true;
            this.BtnCheckGuess.Click += new System.EventHandler(this.BtnCheckGuess_Click);
            // 
            // BtnPickShowNumber
            // 
            this.BtnPickShowNumber.Location = new System.Drawing.Point(51, 245);
            this.BtnPickShowNumber.Name = "BtnPickShowNumber";
            this.BtnPickShowNumber.Size = new System.Drawing.Size(94, 23);
            this.BtnPickShowNumber.TabIndex = 1;
            this.BtnPickShowNumber.Text = "Pick Number";
            this.BtnPickShowNumber.UseVisualStyleBackColor = true;
            this.BtnPickShowNumber.Click += new System.EventHandler(this.BtnPickShowNumber_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(238, 245);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnnumericUpDown1
            // 
            this.BtnnumericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnnumericUpDown1.ForeColor = System.Drawing.Color.Red;
            this.BtnnumericUpDown1.Location = new System.Drawing.Point(110, 172);
            this.BtnnumericUpDown1.Name = "BtnnumericUpDown1";
            this.BtnnumericUpDown1.Size = new System.Drawing.Size(146, 29);
            this.BtnnumericUpDown1.TabIndex = 3;
            this.BtnnumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnnumericUpDown1.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.BtnnumericUpDown1.ValueChanged += new System.EventHandler(this.BtnnumericUpDown1_ValueChanged);
            // 
            // txtTextBox
            // 
            this.txtTextBox.ForeColor = System.Drawing.Color.Blue;
            this.txtTextBox.Location = new System.Drawing.Point(12, 12);
            this.txtTextBox.Multiline = true;
            this.txtTextBox.Name = "txtTextBox";
            this.txtTextBox.Size = new System.Drawing.Size(338, 151);
            this.txtTextBox.TabIndex = 4;
            // 
            // FrmGuessingNumberGameUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 296);
            this.Controls.Add(this.txtTextBox);
            this.Controls.Add(this.BtnnumericUpDown1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnPickShowNumber);
            this.Controls.Add(this.BtnCheckGuess);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "FrmGuessingNumberGameUpdate";
            this.Text = "Guess the number!";
            this.Load += new System.EventHandler(this.FrmGuessingNumberGameUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnnumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCheckGuess;
        private System.Windows.Forms.Button BtnPickShowNumber;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.NumericUpDown BtnnumericUpDown1;
        private System.Windows.Forms.TextBox txtTextBox;
    }
}

