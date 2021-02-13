namespace Exam1IngramTyler
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
            this.totalTouchdownsLabel = new System.Windows.Forms.Label();
            this.totalExtraPointsLabel = new System.Windows.Forms.Label();
            this.totalFieldGoalsLabel = new System.Windows.Forms.Label();
            this.totalPointsLabel = new System.Windows.Forms.Label();
            this.totalTouchdownsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearPassingPlayPicture = new System.Windows.Forms.Button();
            this.clickHereButton = new System.Windows.Forms.Button();
            this.totalPointsOutputLabel = new System.Windows.Forms.Label();
            this.totalFieldGoalsTextBox = new System.Windows.Forms.TextBox();
            this.totalPointKicksTextBox = new System.Windows.Forms.TextBox();
            this.computeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.passPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 229);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // totalTouchdownsLabel
            // 
            this.totalTouchdownsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalTouchdownsLabel.Location = new System.Drawing.Point(6, 24);
            this.totalTouchdownsLabel.Name = "totalTouchdownsLabel";
            this.totalTouchdownsLabel.Size = new System.Drawing.Size(116, 15);
            this.totalTouchdownsLabel.TabIndex = 8;
            this.totalTouchdownsLabel.Text = "Total touchdowns:";
            this.totalTouchdownsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalExtraPointsLabel
            // 
            this.totalExtraPointsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalExtraPointsLabel.Location = new System.Drawing.Point(6, 60);
            this.totalExtraPointsLabel.Name = "totalExtraPointsLabel";
            this.totalExtraPointsLabel.Size = new System.Drawing.Size(116, 15);
            this.totalExtraPointsLabel.TabIndex = 9;
            this.totalExtraPointsLabel.Text = "Total extra point kicks:";
            this.totalExtraPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalFieldGoalsLabel
            // 
            this.totalFieldGoalsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalFieldGoalsLabel.Location = new System.Drawing.Point(6, 91);
            this.totalFieldGoalsLabel.Name = "totalFieldGoalsLabel";
            this.totalFieldGoalsLabel.Size = new System.Drawing.Size(116, 20);
            this.totalFieldGoalsLabel.TabIndex = 10;
            this.totalFieldGoalsLabel.Text = "Total field goals:";
            this.totalFieldGoalsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalPointsLabel
            // 
            this.totalPointsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPointsLabel.Location = new System.Drawing.Point(6, 128);
            this.totalPointsLabel.Name = "totalPointsLabel";
            this.totalPointsLabel.Size = new System.Drawing.Size(116, 21);
            this.totalPointsLabel.TabIndex = 11;
            this.totalPointsLabel.Text = "Total points scored:";
            this.totalPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalTouchdownsTextBox
            // 
            this.totalTouchdownsTextBox.Location = new System.Drawing.Point(147, 19);
            this.totalTouchdownsTextBox.Name = "totalTouchdownsTextBox";
            this.totalTouchdownsTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTouchdownsTextBox.TabIndex = 0;
            this.totalTouchdownsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exitButton);
            this.groupBox1.Controls.Add(this.clearPassingPlayPicture);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.clickHereButton);
            this.groupBox1.Controls.Add(this.computeButton);
            this.groupBox1.Controls.Add(this.totalPointsOutputLabel);
            this.groupBox1.Controls.Add(this.totalFieldGoalsTextBox);
            this.groupBox1.Controls.Add(this.totalPointKicksTextBox);
            this.groupBox1.Controls.Add(this.totalTouchdownsTextBox);
            this.groupBox1.Controls.Add(this.totalPointsLabel);
            this.groupBox1.Controls.Add(this.totalExtraPointsLabel);
            this.groupBox1.Controls.Add(this.totalFieldGoalsLabel);
            this.groupBox1.Controls.Add(this.totalTouchdownsLabel);
            this.groupBox1.Location = new System.Drawing.Point(21, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 206);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // clearPassingPlayPicture
            // 
            this.clearPassingPlayPicture.Location = new System.Drawing.Point(305, 60);
            this.clearPassingPlayPicture.Name = "clearPassingPlayPicture";
            this.clearPassingPlayPicture.Size = new System.Drawing.Size(114, 62);
            this.clearPassingPlayPicture.TabIndex = 7;
            this.clearPassingPlayPicture.Text = "CLEAR passing play picture.";
            this.clearPassingPlayPicture.UseVisualStyleBackColor = true;
            this.clearPassingPlayPicture.Click += new System.EventHandler(this.clearPassingPlayPicture_Click);
            // 
            // clickHereButton
            // 
            this.clickHereButton.Location = new System.Drawing.Point(305, 11);
            this.clickHereButton.Name = "clickHereButton";
            this.clickHereButton.Size = new System.Drawing.Size(153, 38);
            this.clickHereButton.TabIndex = 6;
            this.clickHereButton.Text = "Hard Core Bobcats CLICK here.";
            this.clickHereButton.UseVisualStyleBackColor = true;
            this.clickHereButton.Click += new System.EventHandler(this.clickHereButton_Click);
            // 
            // totalPointsOutputLabel
            // 
            this.totalPointsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalPointsOutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPointsOutputLabel.Location = new System.Drawing.Point(147, 123);
            this.totalPointsOutputLabel.Name = "totalPointsOutputLabel";
            this.totalPointsOutputLabel.Size = new System.Drawing.Size(102, 29);
            this.totalPointsOutputLabel.TabIndex = 12;
            this.totalPointsOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalFieldGoalsTextBox
            // 
            this.totalFieldGoalsTextBox.Location = new System.Drawing.Point(147, 91);
            this.totalFieldGoalsTextBox.Name = "totalFieldGoalsTextBox";
            this.totalFieldGoalsTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalFieldGoalsTextBox.TabIndex = 2;
            this.totalFieldGoalsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalPointKicksTextBox
            // 
            this.totalPointKicksTextBox.Location = new System.Drawing.Point(147, 55);
            this.totalPointKicksTextBox.Name = "totalPointKicksTextBox";
            this.totalPointKicksTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalPointKicksTextBox.TabIndex = 1;
            this.totalPointKicksTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // computeButton
            // 
            this.computeButton.Location = new System.Drawing.Point(6, 162);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(150, 38);
            this.computeButton.TabIndex = 3;
            this.computeButton.Text = "COMPUTE AND DISPLAY TOTAL POINTS SCORED";
            this.computeButton.UseVisualStyleBackColor = true;
            this.computeButton.Click += new System.EventHandler(this.computeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(174, 165);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 35);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(305, 162);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 35);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // passPictureBox
            // 
            this.passPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("passPictureBox.Image")));
            this.passPictureBox.Location = new System.Drawing.Point(269, 12);
            this.passPictureBox.Name = "passPictureBox";
            this.passPictureBox.Size = new System.Drawing.Size(285, 205);
            this.passPictureBox.TabIndex = 14;
            this.passPictureBox.TabStop = false;
            this.passPictureBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.passPictureBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label totalTouchdownsLabel;
        private System.Windows.Forms.Label totalExtraPointsLabel;
        private System.Windows.Forms.Label totalFieldGoalsLabel;
        private System.Windows.Forms.Label totalPointsLabel;
        private System.Windows.Forms.TextBox totalTouchdownsTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearPassingPlayPicture;
        private System.Windows.Forms.Button clickHereButton;
        private System.Windows.Forms.Label totalPointsOutputLabel;
        private System.Windows.Forms.TextBox totalFieldGoalsTextBox;
        private System.Windows.Forms.TextBox totalPointKicksTextBox;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox passPictureBox;
    }
}

