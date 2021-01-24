namespace Fuel_Economy
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
            this.gallonsUsedLabel = new System.Windows.Forms.Label();
            this.mpgLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.milesDroveLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.milesDrivenTextBox = new System.Windows.Forms.TextBox();
            this.gallonsUsedTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // gallonsUsedLabel
            // 
            this.gallonsUsedLabel.AutoSize = true;
            this.gallonsUsedLabel.Location = new System.Drawing.Point(60, 50);
            this.gallonsUsedLabel.Name = "gallonsUsedLabel";
            this.gallonsUsedLabel.Size = new System.Drawing.Size(147, 13);
            this.gallonsUsedLabel.TabIndex = 1;
            this.gallonsUsedLabel.Text = "Enter the gallons of gas used:";
            this.gallonsUsedLabel.Click += new System.EventHandler(this.gallonsUsedLabel_Click);
            // 
            // mpgLabel
            // 
            this.mpgLabel.AutoSize = true;
            this.mpgLabel.Location = new System.Drawing.Point(119, 98);
            this.mpgLabel.Name = "mpgLabel";
            this.mpgLabel.Size = new System.Drawing.Size(84, 13);
            this.mpgLabel.TabIndex = 2;
            this.mpgLabel.Text = "Your car\'s MPG:";
            this.mpgLabel.Click += new System.EventHandler(this.mpgLabel_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(229, 88);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(100, 23);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Click += new System.EventHandler(this.outputLabel_Click);
            // 
            // milesDroveLabel
            // 
            this.milesDroveLabel.AutoSize = true;
            this.milesDroveLabel.Location = new System.Drawing.Point(60, 24);
            this.milesDroveLabel.Name = "milesDroveLabel";
            this.milesDroveLabel.Size = new System.Drawing.Size(143, 13);
            this.milesDroveLabel.TabIndex = 6;
            this.milesDroveLabel.Text = "Enter number of miles driven:";
            this.milesDroveLabel.Click += new System.EventHandler(this.milesDroveLabel_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(160, 157);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 35);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate MPG";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(241, 157);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 35);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // milesDrivenTextBox
            // 
            this.milesDrivenTextBox.Location = new System.Drawing.Point(241, 21);
            this.milesDrivenTextBox.Name = "milesDrivenTextBox";
            this.milesDrivenTextBox.Size = new System.Drawing.Size(100, 20);
            this.milesDrivenTextBox.TabIndex = 9;
            this.milesDrivenTextBox.TextChanged += new System.EventHandler(this.milesDrivenTextBox_TextChanged);
            // 
            // gallonsUsedTextBox
            // 
            this.gallonsUsedTextBox.Location = new System.Drawing.Point(241, 47);
            this.gallonsUsedTextBox.Name = "gallonsUsedTextBox";
            this.gallonsUsedTextBox.Size = new System.Drawing.Size(100, 20);
            this.gallonsUsedTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 204);
            this.Controls.Add(this.gallonsUsedTextBox);
            this.Controls.Add(this.milesDrivenTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.milesDroveLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.mpgLabel);
            this.Controls.Add(this.gallonsUsedLabel);
            this.Name = "Form1";
            this.Text = "MPG Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label gallonsUsedLabel;
        private System.Windows.Forms.Label mpgLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label milesDroveLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox milesDrivenTextBox;
        private System.Windows.Forms.TextBox gallonsUsedTextBox;
    }
}

