namespace hangmanApp
{
    partial class Form1
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
            this.hangmanLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.easyMode = new System.Windows.Forms.RadioButton();
            this.normalMode = new System.Windows.Forms.RadioButton();
            this.hardMode = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // hangmanLabel
            // 
            this.hangmanLabel.AutoSize = true;
            this.hangmanLabel.Location = new System.Drawing.Point(362, 25);
            this.hangmanLabel.Name = "hangmanLabel";
            this.hangmanLabel.Size = new System.Drawing.Size(53, 13);
            this.hangmanLabel.TabIndex = 0;
            this.hangmanLabel.Text = "Hangman";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(661, 380);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(576, 380);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 23);
            this.restartButton.TabIndex = 2;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(353, 66);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play!";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Difficulty";
            // 
            // easyMode
            // 
            this.easyMode.AutoSize = true;
            this.easyMode.Location = new System.Drawing.Point(605, 66);
            this.easyMode.Name = "easyMode";
            this.easyMode.Size = new System.Drawing.Size(48, 17);
            this.easyMode.TabIndex = 5;
            this.easyMode.TabStop = true;
            this.easyMode.Text = "Easy";
            this.easyMode.UseVisualStyleBackColor = true;
            // 
            // normalMode
            // 
            this.normalMode.AutoSize = true;
            this.normalMode.Location = new System.Drawing.Point(605, 100);
            this.normalMode.Name = "normalMode";
            this.normalMode.Size = new System.Drawing.Size(58, 17);
            this.normalMode.TabIndex = 6;
            this.normalMode.TabStop = true;
            this.normalMode.Text = "Normal";
            this.normalMode.UseVisualStyleBackColor = true;
            // 
            // hardMode
            // 
            this.hardMode.AutoSize = true;
            this.hardMode.Location = new System.Drawing.Point(605, 133);
            this.hardMode.Name = "hardMode";
            this.hardMode.Size = new System.Drawing.Size(48, 17);
            this.hardMode.TabIndex = 7;
            this.hardMode.TabStop = true;
            this.hardMode.Text = "Hard";
            this.hardMode.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hardMode);
            this.Controls.Add(this.normalMode);
            this.Controls.Add(this.easyMode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.hangmanLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hangmanLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton easyMode;
        private System.Windows.Forms.RadioButton normalMode;
        private System.Windows.Forms.RadioButton hardMode;
    }
}

