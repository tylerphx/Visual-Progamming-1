namespace Assignment4
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
            this.exitButton = new System.Windows.Forms.Button();
            this.processButton = new System.Windows.Forms.Button();
            this.gradeListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(98, 201);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 36);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(7, 201);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(85, 36);
            this.processButton.TabIndex = 1;
            this.processButton.Text = "Process Input FIle";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // gradeListBox
            // 
            this.gradeListBox.FormattingEnabled = true;
            this.gradeListBox.Location = new System.Drawing.Point(7, 22);
            this.gradeListBox.Name = "gradeListBox";
            this.gradeListBox.Size = new System.Drawing.Size(176, 160);
            this.gradeListBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 249);
            this.Controls.Add(this.gradeListBox);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.ListBox gradeListBox;
    }
}

