namespace NameFormatterCh3
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
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.mediumTranslatedButton = new System.Windows.Forms.Button();
            this.dexterTranslatedButton = new System.Windows.Forms.Button();
            this.sinisterLabel = new System.Windows.Forms.Label();
            this.dexterLabel = new System.Windows.Forms.Label();
            this.mediumLabel = new System.Windows.Forms.Label();
            this.sinisterTranslatedLabel = new System.Windows.Forms.Label();
            this.dexterTranslatedLabel = new System.Windows.Forms.Label();
            this.mediumTranslatedLabel = new System.Windows.Forms.Label();
            this.sinisterTranslatedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(106, 277);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 20;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(213, 277);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 21;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // mediumTranslatedButton
            // 
            this.mediumTranslatedButton.Location = new System.Drawing.Point(123, 169);
            this.mediumTranslatedButton.Name = "mediumTranslatedButton";
            this.mediumTranslatedButton.Size = new System.Drawing.Size(165, 23);
            this.mediumTranslatedButton.TabIndex = 22;
            this.mediumTranslatedButton.Text = "Click here to transfer to english!";
            this.mediumTranslatedButton.UseVisualStyleBackColor = true;
            this.mediumTranslatedButton.Click += new System.EventHandler(this.mediumTranslatedButton_Click);
            // 
            // dexterTranslatedButton
            // 
            this.dexterTranslatedButton.Location = new System.Drawing.Point(123, 111);
            this.dexterTranslatedButton.Name = "dexterTranslatedButton";
            this.dexterTranslatedButton.Size = new System.Drawing.Size(165, 23);
            this.dexterTranslatedButton.TabIndex = 23;
            this.dexterTranslatedButton.Text = "Click here to transfer to english!";
            this.dexterTranslatedButton.UseVisualStyleBackColor = true;
            this.dexterTranslatedButton.Click += new System.EventHandler(this.dexterTranslatedButton_Click);
            // 
            // sinisterLabel
            // 
            this.sinisterLabel.AutoSize = true;
            this.sinisterLabel.Location = new System.Drawing.Point(38, 54);
            this.sinisterLabel.Name = "sinisterLabel";
            this.sinisterLabel.Size = new System.Drawing.Size(41, 13);
            this.sinisterLabel.TabIndex = 25;
            this.sinisterLabel.Text = "Sinister";
            // 
            // dexterLabel
            // 
            this.dexterLabel.AutoSize = true;
            this.dexterLabel.Location = new System.Drawing.Point(38, 116);
            this.dexterLabel.Name = "dexterLabel";
            this.dexterLabel.Size = new System.Drawing.Size(38, 13);
            this.dexterLabel.TabIndex = 26;
            this.dexterLabel.Text = "Dexter";
            // 
            // mediumLabel
            // 
            this.mediumLabel.AutoSize = true;
            this.mediumLabel.Location = new System.Drawing.Point(38, 179);
            this.mediumLabel.Name = "mediumLabel";
            this.mediumLabel.Size = new System.Drawing.Size(44, 13);
            this.mediumLabel.TabIndex = 27;
            this.mediumLabel.Text = "Medium";
            // 
            // sinisterTranslatedLabel
            // 
            this.sinisterTranslatedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sinisterTranslatedLabel.Location = new System.Drawing.Point(311, 58);
            this.sinisterTranslatedLabel.Name = "sinisterTranslatedLabel";
            this.sinisterTranslatedLabel.Size = new System.Drawing.Size(100, 23);
            this.sinisterTranslatedLabel.TabIndex = 28;
            // 
            // dexterTranslatedLabel
            // 
            this.dexterTranslatedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dexterTranslatedLabel.Location = new System.Drawing.Point(311, 111);
            this.dexterTranslatedLabel.Name = "dexterTranslatedLabel";
            this.dexterTranslatedLabel.Size = new System.Drawing.Size(100, 23);
            this.dexterTranslatedLabel.TabIndex = 29;
            // 
            // mediumTranslatedLabel
            // 
            this.mediumTranslatedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mediumTranslatedLabel.Location = new System.Drawing.Point(311, 169);
            this.mediumTranslatedLabel.Name = "mediumTranslatedLabel";
            this.mediumTranslatedLabel.Size = new System.Drawing.Size(100, 23);
            this.mediumTranslatedLabel.TabIndex = 30;
            // 
            // sinisterTranslatedButton
            // 
            this.sinisterTranslatedButton.Location = new System.Drawing.Point(123, 54);
            this.sinisterTranslatedButton.Name = "sinisterTranslatedButton";
            this.sinisterTranslatedButton.Size = new System.Drawing.Size(165, 23);
            this.sinisterTranslatedButton.TabIndex = 31;
            this.sinisterTranslatedButton.Text = "Click here to translate!";
            this.sinisterTranslatedButton.UseVisualStyleBackColor = true;
            this.sinisterTranslatedButton.Click += new System.EventHandler(this.sinisterTranslatedButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 307);
            this.Controls.Add(this.sinisterTranslatedButton);
            this.Controls.Add(this.mediumTranslatedLabel);
            this.Controls.Add(this.dexterTranslatedLabel);
            this.Controls.Add(this.sinisterTranslatedLabel);
            this.Controls.Add(this.mediumLabel);
            this.Controls.Add(this.dexterLabel);
            this.Controls.Add(this.sinisterLabel);
            this.Controls.Add(this.dexterTranslatedButton);
            this.Controls.Add(this.mediumTranslatedButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button mediumTranslatedButton;
        private System.Windows.Forms.Button dexterTranslatedButton;
        private System.Windows.Forms.Label sinisterLabel;
        private System.Windows.Forms.Label dexterLabel;
        private System.Windows.Forms.Label mediumLabel;
        private System.Windows.Forms.Label sinisterTranslatedLabel;
        private System.Windows.Forms.Label dexterTranslatedLabel;
        private System.Windows.Forms.Label mediumTranslatedLabel;
        private System.Windows.Forms.Button sinisterTranslatedButton;
    }
}

