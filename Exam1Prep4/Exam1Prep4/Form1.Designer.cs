namespace Exam1Prep4
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
            this.processButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.vatTaxLabelInstructions = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tipLabelInstructions = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.crossaintTextBox = new System.Windows.Forms.TextBox();
            this.coffeeDrankTextBox = new System.Windows.Forms.TextBox();
            this.tipLabelOutput = new System.Windows.Forms.Label();
            this.vatLabelOutput = new System.Windows.Forms.Label();
            this.TotalLabelOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(96, 309);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(75, 23);
            this.processButton.TabIndex = 2;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(197, 309);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(291, 309);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // vatTaxLabelInstructions
            // 
            this.vatTaxLabelInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vatTaxLabelInstructions.Location = new System.Drawing.Point(12, 165);
            this.vatTaxLabelInstructions.Name = "vatTaxLabelInstructions";
            this.vatTaxLabelInstructions.Size = new System.Drawing.Size(100, 23);
            this.vatTaxLabelInstructions.TabIndex = 3;
            this.vatTaxLabelInstructions.Text = "VAT Tax:";
            this.vatTaxLabelInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(266, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tipLabelInstructions
            // 
            this.tipLabelInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipLabelInstructions.Location = new System.Drawing.Point(12, 124);
            this.tipLabelInstructions.Name = "tipLabelInstructions";
            this.tipLabelInstructions.Size = new System.Drawing.Size(100, 23);
            this.tipLabelInstructions.TabIndex = 6;
            this.tipLabelInstructions.Text = "Tip:";
            this.tipLabelInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(12, 208);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(100, 23);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Total:";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "# of Coffee\'s Drank";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "# of Crossaints Eaten";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // crossaintTextBox
            // 
            this.crossaintTextBox.Location = new System.Drawing.Point(130, 33);
            this.crossaintTextBox.Name = "crossaintTextBox";
            this.crossaintTextBox.Size = new System.Drawing.Size(100, 20);
            this.crossaintTextBox.TabIndex = 0;
            // 
            // coffeeDrankTextBox
            // 
            this.coffeeDrankTextBox.Location = new System.Drawing.Point(130, 81);
            this.coffeeDrankTextBox.Name = "coffeeDrankTextBox";
            this.coffeeDrankTextBox.Size = new System.Drawing.Size(100, 20);
            this.coffeeDrankTextBox.TabIndex = 1;
            // 
            // tipLabelOutput
            // 
            this.tipLabelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipLabelOutput.Location = new System.Drawing.Point(130, 124);
            this.tipLabelOutput.Name = "tipLabelOutput";
            this.tipLabelOutput.Size = new System.Drawing.Size(100, 23);
            this.tipLabelOutput.TabIndex = 12;
            this.tipLabelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vatLabelOutput
            // 
            this.vatLabelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vatLabelOutput.Location = new System.Drawing.Point(130, 165);
            this.vatLabelOutput.Name = "vatLabelOutput";
            this.vatLabelOutput.Size = new System.Drawing.Size(100, 23);
            this.vatLabelOutput.TabIndex = 13;
            this.vatLabelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalLabelOutput
            // 
            this.TotalLabelOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalLabelOutput.Location = new System.Drawing.Point(130, 208);
            this.TotalLabelOutput.Name = "TotalLabelOutput";
            this.TotalLabelOutput.Size = new System.Drawing.Size(100, 23);
            this.TotalLabelOutput.TabIndex = 14;
            this.TotalLabelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 338);
            this.Controls.Add(this.TotalLabelOutput);
            this.Controls.Add(this.vatLabelOutput);
            this.Controls.Add(this.tipLabelOutput);
            this.Controls.Add(this.coffeeDrankTextBox);
            this.Controls.Add(this.crossaintTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.tipLabelInstructions);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.vatTaxLabelInstructions);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.processButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label vatTaxLabelInstructions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tipLabelInstructions;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox crossaintTextBox;
        private System.Windows.Forms.TextBox coffeeDrankTextBox;
        private System.Windows.Forms.Label tipLabelOutput;
        private System.Windows.Forms.Label vatLabelOutput;
        private System.Windows.Forms.Label TotalLabelOutput;
    }
}

