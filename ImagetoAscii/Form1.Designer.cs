namespace ImagetoAscii
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
            this.DirTextBox = new System.Windows.Forms.TextBox();
            this.DirButton = new System.Windows.Forms.Button();
            this.pictureContainer = new System.Windows.Forms.Panel();
            this.convertButton = new System.Windows.Forms.Button();
            this.asciiTextBox = new System.Windows.Forms.TextBox();
            this.convertprogressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SpaceComboBox = new System.Windows.Forms.ComboBox();
            this.StopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DirTextBox
            // 
            this.DirTextBox.Location = new System.Drawing.Point(13, 13);
            this.DirTextBox.Name = "DirTextBox";
            this.DirTextBox.Size = new System.Drawing.Size(281, 20);
            this.DirTextBox.TabIndex = 0;
            // 
            // DirButton
            // 
            this.DirButton.Location = new System.Drawing.Point(301, 11);
            this.DirButton.Name = "DirButton";
            this.DirButton.Size = new System.Drawing.Size(75, 23);
            this.DirButton.TabIndex = 1;
            this.DirButton.Text = "Open";
            this.DirButton.UseVisualStyleBackColor = true;
            this.DirButton.Click += new System.EventHandler(this.DirButton_Click);
            // 
            // pictureContainer
            // 
            this.pictureContainer.AutoScroll = true;
            this.pictureContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureContainer.Location = new System.Drawing.Point(12, 94);
            this.pictureContainer.Name = "pictureContainer";
            this.pictureContainer.Size = new System.Drawing.Size(282, 336);
            this.pictureContainer.TabIndex = 2;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(235, 36);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convert_Click);
            // 
            // asciiTextBox
            // 
            this.asciiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.asciiTextBox.Location = new System.Drawing.Point(301, 94);
            this.asciiTextBox.MaxLength = 0;
            this.asciiTextBox.Multiline = true;
            this.asciiTextBox.Name = "asciiTextBox";
            this.asciiTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.asciiTextBox.Size = new System.Drawing.Size(311, 336);
            this.asciiTextBox.TabIndex = 4;
            this.asciiTextBox.WordWrap = false;
            // 
            // convertprogressBar
            // 
            this.convertprogressBar.Location = new System.Drawing.Point(12, 65);
            this.convertprogressBar.Name = "convertprogressBar";
            this.convertprogressBar.Size = new System.Drawing.Size(505, 23);
            this.convertprogressBar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Space Per Pixel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpaceComboBox
            // 
            this.SpaceComboBox.FormattingEnabled = true;
            this.SpaceComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.SpaceComboBox.Location = new System.Drawing.Point(108, 38);
            this.SpaceComboBox.MaxDropDownItems = 10;
            this.SpaceComboBox.Name = "SpaceComboBox";
            this.SpaceComboBox.Size = new System.Drawing.Size(121, 21);
            this.SpaceComboBox.TabIndex = 7;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(523, 65);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(89, 23);
            this.StopButton.TabIndex = 8;
            this.StopButton.Text = "Stop Convert";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.SpaceComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.convertprogressBar);
            this.Controls.Add(this.asciiTextBox);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.pictureContainer);
            this.Controls.Add(this.DirButton);
            this.Controls.Add(this.DirTextBox);
            this.Name = "Form1";
            this.Text = "Image to Ascii Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DirTextBox;
        private System.Windows.Forms.Button DirButton;
        private System.Windows.Forms.Panel pictureContainer;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox asciiTextBox;
        private System.Windows.Forms.ProgressBar convertprogressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SpaceComboBox;
        private System.Windows.Forms.Button StopButton;
    }
}

