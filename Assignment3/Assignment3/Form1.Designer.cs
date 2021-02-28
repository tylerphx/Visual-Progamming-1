namespace Assignment3
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
            this.label1 = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.addWorkShopButton = new System.Windows.Forms.Button();
            this.calculateTotalButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.workShopListBox = new System.Windows.Forms.ListBox();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.costListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Cost:";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(196, 163);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(100, 22);
            this.outputLabel.TabIndex = 3;
            // 
            // addWorkShopButton
            // 
            this.addWorkShopButton.Location = new System.Drawing.Point(52, 236);
            this.addWorkShopButton.Name = "addWorkShopButton";
            this.addWorkShopButton.Size = new System.Drawing.Size(87, 34);
            this.addWorkShopButton.TabIndex = 4;
            this.addWorkShopButton.Text = "Add Workshop";
            this.addWorkShopButton.UseVisualStyleBackColor = true;
            this.addWorkShopButton.Click += new System.EventHandler(this.addWorkShopButton_Click);
            // 
            // calculateTotalButton
            // 
            this.calculateTotalButton.Location = new System.Drawing.Point(145, 236);
            this.calculateTotalButton.Name = "calculateTotalButton";
            this.calculateTotalButton.Size = new System.Drawing.Size(88, 34);
            this.calculateTotalButton.TabIndex = 5;
            this.calculateTotalButton.Text = "Calculate Total";
            this.calculateTotalButton.UseVisualStyleBackColor = true;
            this.calculateTotalButton.Click += new System.EventHandler(this.calculateTotalButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(239, 236);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(94, 34);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(339, 236);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(98, 34);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // workShopListBox
            // 
            this.workShopListBox.FormattingEnabled = true;
            this.workShopListBox.Location = new System.Drawing.Point(25, 40);
            this.workShopListBox.Name = "workShopListBox";
            this.workShopListBox.Size = new System.Drawing.Size(120, 95);
            this.workShopListBox.TabIndex = 8;
            // 
            // locationListBox
            // 
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.Location = new System.Drawing.Point(184, 40);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(120, 95);
            this.locationListBox.TabIndex = 9;
            // 
            // costListBox
            // 
            this.costListBox.FormattingEnabled = true;
            this.costListBox.Location = new System.Drawing.Point(339, 40);
            this.costListBox.Name = "costListBox";
            this.costListBox.Size = new System.Drawing.Size(120, 95);
            this.costListBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pick a Workshop";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pick a Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "List of Costs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 282);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.costListBox);
            this.Controls.Add(this.locationListBox);
            this.Controls.Add(this.workShopListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.calculateTotalButton);
            this.Controls.Add(this.addWorkShopButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button addWorkShopButton;
        private System.Windows.Forms.Button calculateTotalButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox workShopListBox;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.ListBox costListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

