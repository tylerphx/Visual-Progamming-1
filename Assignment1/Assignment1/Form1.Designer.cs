namespace Assignment1
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
            this.ticketsSoldInstructionsLabel = new System.Windows.Forms.Label();
            this.classATicketsLabel = new System.Windows.Forms.Label();
            this.classBTicketsLabel = new System.Windows.Forms.Label();
            this.classCTicketsLabel = new System.Windows.Forms.Label();
            this.calculateRevenueButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.ticketsSoldGroupBox = new System.Windows.Forms.GroupBox();
            this.classATextBox = new System.Windows.Forms.TextBox();
            this.classBTextBox = new System.Windows.Forms.TextBox();
            this.classCTextBox = new System.Windows.Forms.TextBox();
            this.revenueGeneratedGroupBox = new System.Windows.Forms.GroupBox();
            this.classARevenueLabel = new System.Windows.Forms.Label();
            this.classBRevenueLabel = new System.Windows.Forms.Label();
            this.classCRevenueLabel = new System.Windows.Forms.Label();
            this.classBRevenueOutputLabel = new System.Windows.Forms.Label();
            this.classCRevenueOutputLabel = new System.Windows.Forms.Label();
            this.totalOutputLabel = new System.Windows.Forms.Label();
            this.classARevenueOutputLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.ticketsSoldGroupBox.SuspendLayout();
            this.revenueGeneratedGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ticketsSoldInstructionsLabel
            // 
            this.ticketsSoldInstructionsLabel.Location = new System.Drawing.Point(31, 30);
            this.ticketsSoldInstructionsLabel.Name = "ticketsSoldInstructionsLabel";
            this.ticketsSoldInstructionsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ticketsSoldInstructionsLabel.Size = new System.Drawing.Size(199, 53);
            this.ticketsSoldInstructionsLabel.TabIndex = 11;
            this.ticketsSoldInstructionsLabel.Text = "Enter the number of tickets sold for each class of seats.";
            this.ticketsSoldInstructionsLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // classATicketsLabel
            // 
            this.classATicketsLabel.AutoSize = true;
            this.classATicketsLabel.Location = new System.Drawing.Point(52, 73);
            this.classATicketsLabel.Name = "classATicketsLabel";
            this.classATicketsLabel.Size = new System.Drawing.Size(45, 13);
            this.classATicketsLabel.TabIndex = 6;
            this.classATicketsLabel.Text = "Class A:";
            // 
            // classBTicketsLabel
            // 
            this.classBTicketsLabel.AutoSize = true;
            this.classBTicketsLabel.Location = new System.Drawing.Point(52, 104);
            this.classBTicketsLabel.Name = "classBTicketsLabel";
            this.classBTicketsLabel.Size = new System.Drawing.Size(45, 13);
            this.classBTicketsLabel.TabIndex = 3;
            this.classBTicketsLabel.Text = "Class B:";
            // 
            // classCTicketsLabel
            // 
            this.classCTicketsLabel.AutoSize = true;
            this.classCTicketsLabel.Location = new System.Drawing.Point(52, 136);
            this.classCTicketsLabel.Name = "classCTicketsLabel";
            this.classCTicketsLabel.Size = new System.Drawing.Size(45, 13);
            this.classCTicketsLabel.TabIndex = 4;
            this.classCTicketsLabel.Text = "Class C:";
            // 
            // calculateRevenueButton
            // 
            this.calculateRevenueButton.Location = new System.Drawing.Point(139, 187);
            this.calculateRevenueButton.Name = "calculateRevenueButton";
            this.calculateRevenueButton.Size = new System.Drawing.Size(75, 42);
            this.calculateRevenueButton.TabIndex = 14;
            this.calculateRevenueButton.Text = "Calculate Revenue";
            this.calculateRevenueButton.UseVisualStyleBackColor = true;
            this.calculateRevenueButton.Click += new System.EventHandler(this.calculateRevenueButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(220, 187);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 42);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(302, 187);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 42);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ticketsSoldGroupBox
            // 
            this.ticketsSoldGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.ticketsSoldGroupBox.Controls.Add(this.classCTextBox);
            this.ticketsSoldGroupBox.Controls.Add(this.classBTextBox);
            this.ticketsSoldGroupBox.Controls.Add(this.classATextBox);
            this.ticketsSoldGroupBox.Controls.Add(this.classATicketsLabel);
            this.ticketsSoldGroupBox.Controls.Add(this.classBTicketsLabel);
            this.ticketsSoldGroupBox.Controls.Add(this.classCTicketsLabel);
            this.ticketsSoldGroupBox.Controls.Add(this.ticketsSoldInstructionsLabel);
            this.ticketsSoldGroupBox.Location = new System.Drawing.Point(-6, 12);
            this.ticketsSoldGroupBox.Name = "ticketsSoldGroupBox";
            this.ticketsSoldGroupBox.Size = new System.Drawing.Size(254, 169);
            this.ticketsSoldGroupBox.TabIndex = 13;
            this.ticketsSoldGroupBox.TabStop = false;
            this.ticketsSoldGroupBox.Text = "Tickets Sold";
            // 
            // classATextBox
            // 
            this.classATextBox.Location = new System.Drawing.Point(103, 70);
            this.classATextBox.Name = "classATextBox";
            this.classATextBox.Size = new System.Drawing.Size(100, 20);
            this.classATextBox.TabIndex = 0;
            this.classATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // classBTextBox
            // 
            this.classBTextBox.Location = new System.Drawing.Point(103, 101);
            this.classBTextBox.Name = "classBTextBox";
            this.classBTextBox.Size = new System.Drawing.Size(100, 20);
            this.classBTextBox.TabIndex = 1;
            this.classBTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // classCTextBox
            // 
            this.classCTextBox.Location = new System.Drawing.Point(103, 133);
            this.classCTextBox.Name = "classCTextBox";
            this.classCTextBox.Size = new System.Drawing.Size(100, 20);
            this.classCTextBox.TabIndex = 2;
            this.classCTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // revenueGeneratedGroupBox
            // 
            this.revenueGeneratedGroupBox.Controls.Add(this.totalLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.classARevenueLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.classBRevenueLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.classARevenueOutputLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.classCRevenueLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.classBRevenueOutputLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.classCRevenueOutputLabel);
            this.revenueGeneratedGroupBox.Controls.Add(this.totalOutputLabel);
            this.revenueGeneratedGroupBox.Location = new System.Drawing.Point(254, 12);
            this.revenueGeneratedGroupBox.Name = "revenueGeneratedGroupBox";
            this.revenueGeneratedGroupBox.Size = new System.Drawing.Size(221, 169);
            this.revenueGeneratedGroupBox.TabIndex = 14;
            this.revenueGeneratedGroupBox.TabStop = false;
            this.revenueGeneratedGroupBox.Text = "Revenue Generated";
            // 
            // classARevenueLabel
            // 
            this.classARevenueLabel.AutoSize = true;
            this.classARevenueLabel.Location = new System.Drawing.Point(26, 46);
            this.classARevenueLabel.Name = "classARevenueLabel";
            this.classARevenueLabel.Size = new System.Drawing.Size(45, 13);
            this.classARevenueLabel.TabIndex = 8;
            this.classARevenueLabel.Text = "Class A:";
            // 
            // classBRevenueLabel
            // 
            this.classBRevenueLabel.AutoSize = true;
            this.classBRevenueLabel.Location = new System.Drawing.Point(26, 77);
            this.classBRevenueLabel.Name = "classBRevenueLabel";
            this.classBRevenueLabel.Size = new System.Drawing.Size(45, 13);
            this.classBRevenueLabel.TabIndex = 9;
            this.classBRevenueLabel.Text = "Class B:";
            // 
            // classCRevenueLabel
            // 
            this.classCRevenueLabel.AutoSize = true;
            this.classCRevenueLabel.Location = new System.Drawing.Point(26, 109);
            this.classCRevenueLabel.Name = "classCRevenueLabel";
            this.classCRevenueLabel.Size = new System.Drawing.Size(45, 13);
            this.classCRevenueLabel.TabIndex = 10;
            this.classCRevenueLabel.Text = "Class C:";
            // 
            // classBRevenueOutputLabel
            // 
            this.classBRevenueOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classBRevenueOutputLabel.Location = new System.Drawing.Point(94, 77);
            this.classBRevenueOutputLabel.Name = "classBRevenueOutputLabel";
            this.classBRevenueOutputLabel.Size = new System.Drawing.Size(86, 22);
            this.classBRevenueOutputLabel.TabIndex = 7;
            this.classBRevenueOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classCRevenueOutputLabel
            // 
            this.classCRevenueOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classCRevenueOutputLabel.Location = new System.Drawing.Point(94, 109);
            this.classCRevenueOutputLabel.Name = "classCRevenueOutputLabel";
            this.classCRevenueOutputLabel.Size = new System.Drawing.Size(86, 22);
            this.classCRevenueOutputLabel.TabIndex = 8;
            this.classCRevenueOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalOutputLabel
            // 
            this.totalOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOutputLabel.Location = new System.Drawing.Point(94, 139);
            this.totalOutputLabel.Name = "totalOutputLabel";
            this.totalOutputLabel.Size = new System.Drawing.Size(86, 23);
            this.totalOutputLabel.TabIndex = 9;
            this.totalOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalOutputLabel.Click += new System.EventHandler(this.totalOutputLabel_Click);
            // 
            // classARevenueOutputLabel
            // 
            this.classARevenueOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classARevenueOutputLabel.Location = new System.Drawing.Point(94, 46);
            this.classARevenueOutputLabel.Name = "classARevenueOutputLabel";
            this.classARevenueOutputLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.classARevenueOutputLabel.Size = new System.Drawing.Size(86, 22);
            this.classARevenueOutputLabel.TabIndex = 6;
            this.classARevenueOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(37, 139);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 13;
            this.totalLabel.Text = "Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 241);
            this.Controls.Add(this.revenueGeneratedGroupBox);
            this.Controls.Add(this.ticketsSoldGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateRevenueButton);
            this.Name = "Form1";
            this.Text = "Stadium Seating";
            this.ticketsSoldGroupBox.ResumeLayout(false);
            this.ticketsSoldGroupBox.PerformLayout();
            this.revenueGeneratedGroupBox.ResumeLayout(false);
            this.revenueGeneratedGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label ticketsSoldInstructionsLabel;
        private System.Windows.Forms.Label classATicketsLabel;
        private System.Windows.Forms.Label classBTicketsLabel;
        private System.Windows.Forms.Label classCTicketsLabel;
        private System.Windows.Forms.Button calculateRevenueButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox ticketsSoldGroupBox;
        private System.Windows.Forms.TextBox classCTextBox;
        private System.Windows.Forms.TextBox classBTextBox;
        private System.Windows.Forms.TextBox classATextBox;
        private System.Windows.Forms.GroupBox revenueGeneratedGroupBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label classARevenueLabel;
        private System.Windows.Forms.Label classBRevenueLabel;
        private System.Windows.Forms.Label classARevenueOutputLabel;
        private System.Windows.Forms.Label classCRevenueLabel;
        private System.Windows.Forms.Label classBRevenueOutputLabel;
        private System.Windows.Forms.Label classCRevenueOutputLabel;
        private System.Windows.Forms.Label totalOutputLabel;
    }
}

