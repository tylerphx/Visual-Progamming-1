namespace Exam1Prep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.thankYouLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.croissantTextBox = new System.Windows.Forms.TextBox();
            this.coffeeTextBox = new System.Windows.Forms.TextBox();
            this.croissantsLabel = new System.Windows.Forms.Label();
            this.CoffeeLabel = new System.Windows.Forms.Label();
            this.tipLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tipOutputLabel = new System.Windows.Forms.Label();
            this.taxOutputLabel = new System.Windows.Forms.Label();
            this.totalOutputLabel = new System.Windows.Forms.Label();
            this.processDataButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(335, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 210);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // thankYouLabel
            // 
            this.thankYouLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.thankYouLabel.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thankYouLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.thankYouLabel.Location = new System.Drawing.Point(368, 240);
            this.thankYouLabel.Name = "thankYouLabel";
            this.thankYouLabel.Size = new System.Drawing.Size(311, 52);
            this.thankYouLabel.TabIndex = 0;
            this.thankYouLabel.Text = "Merci beaucoup at revenez";
            this.thankYouLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalOutputLabel);
            this.groupBox1.Controls.Add(this.taxOutputLabel);
            this.groupBox1.Controls.Add(this.tipOutputLabel);
            this.groupBox1.Controls.Add(this.totalLabel);
            this.groupBox1.Controls.Add(this.taxLabel);
            this.groupBox1.Controls.Add(this.tipLabel);
            this.groupBox1.Controls.Add(this.CoffeeLabel);
            this.groupBox1.Controls.Add(this.croissantsLabel);
            this.groupBox1.Controls.Add(this.coffeeTextBox);
            this.groupBox1.Controls.Add(this.croissantTextBox);
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 196);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // croissantTextBox
            // 
            this.croissantTextBox.Location = new System.Drawing.Point(146, 29);
            this.croissantTextBox.Name = "croissantTextBox";
            this.croissantTextBox.Size = new System.Drawing.Size(100, 20);
            this.croissantTextBox.TabIndex = 0;
            // 
            // coffeeTextBox
            // 
            this.coffeeTextBox.Location = new System.Drawing.Point(146, 67);
            this.coffeeTextBox.Name = "coffeeTextBox";
            this.coffeeTextBox.Size = new System.Drawing.Size(100, 20);
            this.coffeeTextBox.TabIndex = 1;
            // 
            // croissantsLabel
            // 
            this.croissantsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.croissantsLabel.Location = new System.Drawing.Point(11, 29);
            this.croissantsLabel.Name = "croissantsLabel";
            this.croissantsLabel.Size = new System.Drawing.Size(100, 23);
            this.croissantsLabel.TabIndex = 5;
            this.croissantsLabel.Text = "CROISSANTS";
            this.croissantsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CoffeeLabel
            // 
            this.CoffeeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CoffeeLabel.Location = new System.Drawing.Point(11, 64);
            this.CoffeeLabel.Name = "CoffeeLabel";
            this.CoffeeLabel.Size = new System.Drawing.Size(100, 23);
            this.CoffeeLabel.TabIndex = 6;
            this.CoffeeLabel.Text = "Coffee";
            this.CoffeeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipLabel
            // 
            this.tipLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipLabel.Location = new System.Drawing.Point(11, 101);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(100, 23);
            this.tipLabel.TabIndex = 7;
            this.tipLabel.Text = "Tip To Server";
            this.tipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxLabel
            // 
            this.taxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxLabel.Location = new System.Drawing.Point(11, 135);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(100, 23);
            this.taxLabel.TabIndex = 8;
            this.taxLabel.Text = "Tax";
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Location = new System.Drawing.Point(11, 173);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(100, 23);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "Grand Total";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipOutputLabel
            // 
            this.tipOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipOutputLabel.Location = new System.Drawing.Point(146, 101);
            this.tipOutputLabel.Name = "tipOutputLabel";
            this.tipOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.tipOutputLabel.TabIndex = 10;
            this.tipOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxOutputLabel
            // 
            this.taxOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxOutputLabel.Location = new System.Drawing.Point(146, 135);
            this.taxOutputLabel.Name = "taxOutputLabel";
            this.taxOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.taxOutputLabel.TabIndex = 11;
            this.taxOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalOutputLabel
            // 
            this.totalOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOutputLabel.Location = new System.Drawing.Point(146, 170);
            this.totalOutputLabel.Name = "totalOutputLabel";
            this.totalOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.totalOutputLabel.TabIndex = 12;
            this.totalOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // processDataButton
            // 
            this.processDataButton.Location = new System.Drawing.Point(26, 269);
            this.processDataButton.Name = "processDataButton";
            this.processDataButton.Size = new System.Drawing.Size(102, 23);
            this.processDataButton.TabIndex = 3;
            this.processDataButton.Text = "Process Data";
            this.processDataButton.UseVisualStyleBackColor = true;
            this.processDataButton.Click += new System.EventHandler(this.processDataButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(134, 269);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(98, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear All";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(238, 269);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(98, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 304);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.processDataButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.thankYouLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label thankYouLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label totalOutputLabel;
        private System.Windows.Forms.Label taxOutputLabel;
        private System.Windows.Forms.Label tipOutputLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label tipLabel;
        private System.Windows.Forms.Label CoffeeLabel;
        private System.Windows.Forms.Label croissantsLabel;
        private System.Windows.Forms.TextBox coffeeTextBox;
        private System.Windows.Forms.TextBox croissantTextBox;
        private System.Windows.Forms.Button processDataButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

