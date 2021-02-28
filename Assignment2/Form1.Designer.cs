namespace Assignment2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.packageCRadioButton = new System.Windows.Forms.RadioButton();
            this.packageBRadioButton = new System.Windows.Forms.RadioButton();
            this.packageARadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nonprofitCheckBox = new System.Windows.Forms.CheckBox();
            this.hoursUsedInstructionLabel = new System.Windows.Forms.Label();
            this.totalAmountInstructionLabel = new System.Windows.Forms.Label();
            this.hoursUsedLabel = new System.Windows.Forms.TextBox();
            this.totalAmountDueLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.packageCRadioButton);
            this.groupBox1.Controls.Add(this.packageBRadioButton);
            this.groupBox1.Controls.Add(this.packageARadioButton);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Subscription Package";
            // 
            // packageCRadioButton
            // 
            this.packageCRadioButton.AutoSize = true;
            this.packageCRadioButton.Location = new System.Drawing.Point(6, 80);
            this.packageCRadioButton.Name = "packageCRadioButton";
            this.packageCRadioButton.Size = new System.Drawing.Size(78, 17);
            this.packageCRadioButton.TabIndex = 3;
            this.packageCRadioButton.TabStop = true;
            this.packageCRadioButton.Text = "Package C";
            this.packageCRadioButton.UseVisualStyleBackColor = true;
            // 
            // packageBRadioButton
            // 
            this.packageBRadioButton.AutoSize = true;
            this.packageBRadioButton.Location = new System.Drawing.Point(6, 57);
            this.packageBRadioButton.Name = "packageBRadioButton";
            this.packageBRadioButton.Size = new System.Drawing.Size(78, 17);
            this.packageBRadioButton.TabIndex = 2;
            this.packageBRadioButton.TabStop = true;
            this.packageBRadioButton.Text = "Package B";
            this.packageBRadioButton.UseVisualStyleBackColor = true;
            // 
            // packageARadioButton
            // 
            this.packageARadioButton.AutoSize = true;
            this.packageARadioButton.Location = new System.Drawing.Point(6, 34);
            this.packageARadioButton.Name = "packageARadioButton";
            this.packageARadioButton.Size = new System.Drawing.Size(78, 17);
            this.packageARadioButton.TabIndex = 1;
            this.packageARadioButton.TabStop = true;
            this.packageARadioButton.Text = "Package A";
            this.packageARadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nonprofitCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(134, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 67);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a Discount";
            // 
            // nonprofitCheckBox
            // 
            this.nonprofitCheckBox.AutoSize = true;
            this.nonprofitCheckBox.Location = new System.Drawing.Point(6, 30);
            this.nonprofitCheckBox.Name = "nonprofitCheckBox";
            this.nonprofitCheckBox.Size = new System.Drawing.Size(131, 17);
            this.nonprofitCheckBox.TabIndex = 4;
            this.nonprofitCheckBox.Text = "Nonprofit Organization";
            this.nonprofitCheckBox.UseVisualStyleBackColor = true;
            // 
            // hoursUsedInstructionLabel
            // 
            this.hoursUsedInstructionLabel.AutoSize = true;
            this.hoursUsedInstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursUsedInstructionLabel.Location = new System.Drawing.Point(2, 195);
            this.hoursUsedInstructionLabel.Name = "hoursUsedInstructionLabel";
            this.hoursUsedInstructionLabel.Size = new System.Drawing.Size(188, 15);
            this.hoursUsedInstructionLabel.TabIndex = 1;
            this.hoursUsedInstructionLabel.Text = "Enter the Number of Hours Used:";
            // 
            // totalAmountInstructionLabel
            // 
            this.totalAmountInstructionLabel.AutoSize = true;
            this.totalAmountInstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmountInstructionLabel.Location = new System.Drawing.Point(82, 228);
            this.totalAmountInstructionLabel.Name = "totalAmountInstructionLabel";
            this.totalAmountInstructionLabel.Size = new System.Drawing.Size(108, 15);
            this.totalAmountInstructionLabel.TabIndex = 2;
            this.totalAmountInstructionLabel.Text = "Total Amount Due:";
            // 
            // hoursUsedLabel
            // 
            this.hoursUsedLabel.Location = new System.Drawing.Point(196, 190);
            this.hoursUsedLabel.Name = "hoursUsedLabel";
            this.hoursUsedLabel.Size = new System.Drawing.Size(100, 20);
            this.hoursUsedLabel.TabIndex = 3;
            // 
            // totalAmountDueLabel
            // 
            this.totalAmountDueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalAmountDueLabel.Location = new System.Drawing.Point(196, 228);
            this.totalAmountDueLabel.Name = "totalAmountDueLabel";
            this.totalAmountDueLabel.Size = new System.Drawing.Size(100, 23);
            this.totalAmountDueLabel.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(21, 273);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 37);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(115, 273);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 37);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(208, 273);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 37);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 318);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalAmountDueLabel);
            this.Controls.Add(this.hoursUsedLabel);
            this.Controls.Add(this.totalAmountInstructionLabel);
            this.Controls.Add(this.hoursUsedInstructionLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Internet Provider Form 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton packageCRadioButton;
        private System.Windows.Forms.RadioButton packageBRadioButton;
        private System.Windows.Forms.RadioButton packageARadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox nonprofitCheckBox;
        private System.Windows.Forms.Label hoursUsedInstructionLabel;
        private System.Windows.Forms.Label totalAmountInstructionLabel;
        private System.Windows.Forms.TextBox hoursUsedLabel;
        private System.Windows.Forms.Label totalAmountDueLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

