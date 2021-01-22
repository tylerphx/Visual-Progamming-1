namespace MyFirstProject
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.translationLabel = new System.Windows.Forms.Label();
            this.spanishButton = new System.Windows.Forms.Button();
            this.italianButton = new System.Windows.Forms.Button();
            this.germanButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.translationOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // translationLabel
            // 
            this.translationLabel.Location = new System.Drawing.Point(0, 0);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(100, 23);
            this.translationLabel.TabIndex = 7;
            // 
            // spanishButton
            // 
            this.spanishButton.Location = new System.Drawing.Point(154, 79);
            this.spanishButton.Name = "spanishButton";
            this.spanishButton.Size = new System.Drawing.Size(75, 23);
            this.spanishButton.TabIndex = 6;
            this.spanishButton.Text = "Spanish";
            this.spanishButton.UseVisualStyleBackColor = true;
            this.spanishButton.Click += new System.EventHandler(this.spanishButton_Click);
            // 
            // italianButton
            // 
            this.italianButton.Location = new System.Drawing.Point(73, 79);
            this.italianButton.Name = "italianButton";
            this.italianButton.Size = new System.Drawing.Size(75, 23);
            this.italianButton.TabIndex = 8;
            this.italianButton.Text = "Italian";
            this.italianButton.UseVisualStyleBackColor = true;
            this.italianButton.Click += new System.EventHandler(this.italianButton_Click);
            // 
            // germanButton
            // 
            this.germanButton.Location = new System.Drawing.Point(234, 79);
            this.germanButton.Name = "germanButton";
            this.germanButton.Size = new System.Drawing.Size(75, 23);
            this.germanButton.TabIndex = 9;
            this.germanButton.Text = "German";
            this.germanButton.UseVisualStyleBackColor = true;
            this.germanButton.Click += new System.EventHandler(this.germanButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select a language and I will translate the phrase \"Good Morning\"";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // translationOutputLabel
            // 
            this.translationOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translationOutputLabel.Location = new System.Drawing.Point(39, 46);
            this.translationOutputLabel.Name = "translationOutputLabel";
            this.translationOutputLabel.Size = new System.Drawing.Size(326, 23);
            this.translationOutputLabel.TabIndex = 11;
            this.translationOutputLabel.Click += new System.EventHandler(this.translationOutputLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 130);
            this.Controls.Add(this.translationOutputLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.germanButton);
            this.Controls.Add(this.italianButton);
            this.Controls.Add(this.spanishButton);
            this.Controls.Add(this.translationLabel);
            this.Name = "Form1";
            this.Text = "My First Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label translationLabel;
        private System.Windows.Forms.Button spanishButton;
        private System.Windows.Forms.Button italianButton;
        private System.Windows.Forms.Button germanButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label translationOutputLabel;
    }
}

