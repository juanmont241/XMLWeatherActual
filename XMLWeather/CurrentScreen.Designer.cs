namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentScreen));
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.currentDate = new System.Windows.Forms.Label();
            this.outdoorLabel = new System.Windows.Forms.Label();
            this.weatherIcon = new System.Windows.Forms.PictureBox();
            this.searchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.Black;
            this.cityOutput.Location = new System.Drawing.Point(3, 359);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(226, 37);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Underline);
            this.maxLabel.ForeColor = System.Drawing.Color.Black;
            this.maxLabel.Location = new System.Drawing.Point(235, 305);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(66, 31);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "max";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.BackColor = System.Drawing.Color.Transparent;
            this.minLabel.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Underline);
            this.minLabel.ForeColor = System.Drawing.Color.Black;
            this.minLabel.Location = new System.Drawing.Point(235, 359);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(60, 31);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "min";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.Black;
            this.tempLabel.Location = new System.Drawing.Point(112, 82);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(278, 72);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "Current ";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.IndianRed;
            this.label3.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Underline);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Underline);
            this.forecastLabel.ForeColor = System.Drawing.Color.Black;
            this.forecastLabel.Location = new System.Drawing.Point(173, 16);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(109, 50);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // minOutput
            // 
            this.minOutput.AutoSize = true;
            this.minOutput.BackColor = System.Drawing.Color.Transparent;
            this.minOutput.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Underline);
            this.minOutput.ForeColor = System.Drawing.Color.Black;
            this.minOutput.Location = new System.Drawing.Point(372, 359);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(78, 31);
            this.minOutput.TabIndex = 44;
            this.minOutput.Text = "min#";
            // 
            // maxOutput
            // 
            this.maxOutput.AutoSize = true;
            this.maxOutput.BackColor = System.Drawing.Color.Transparent;
            this.maxOutput.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Underline);
            this.maxOutput.ForeColor = System.Drawing.Color.Black;
            this.maxOutput.Location = new System.Drawing.Point(372, 305);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(84, 31);
            this.maxOutput.TabIndex = 45;
            this.maxOutput.Text = "max#";
            // 
            // currentDate
            // 
            this.currentDate.AutoSize = true;
            this.currentDate.BackColor = System.Drawing.Color.Transparent;
            this.currentDate.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Underline);
            this.currentDate.ForeColor = System.Drawing.Color.Black;
            this.currentDate.Location = new System.Drawing.Point(4, 305);
            this.currentDate.Name = "currentDate";
            this.currentDate.Size = new System.Drawing.Size(71, 31);
            this.currentDate.TabIndex = 70;
            this.currentDate.Text = "Date";
            // 
            // outdoorLabel
            // 
            this.outdoorLabel.AutoSize = true;
            this.outdoorLabel.BackColor = System.Drawing.Color.Transparent;
            this.outdoorLabel.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outdoorLabel.ForeColor = System.Drawing.Color.Black;
            this.outdoorLabel.Location = new System.Drawing.Point(4, 203);
            this.outdoorLabel.Name = "outdoorLabel";
            this.outdoorLabel.Size = new System.Drawing.Size(138, 36);
            this.outdoorLabel.TabIndex = 71;
            this.outdoorLabel.Text = "Outdoor";
            // 
            // weatherIcon
            // 
            this.weatherIcon.BackColor = System.Drawing.Color.Transparent;
            this.weatherIcon.InitialImage = null;
            this.weatherIcon.Location = new System.Drawing.Point(222, 157);
            this.weatherIcon.Name = "weatherIcon";
            this.weatherIcon.Size = new System.Drawing.Size(214, 123);
            this.weatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weatherIcon.TabIndex = 72;
            this.weatherIcon.TabStop = false;
            // 
            // searchLabel
            // 
            this.searchLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchLabel.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Underline);
            this.searchLabel.ForeColor = System.Drawing.Color.Black;
            this.searchLabel.Location = new System.Drawing.Point(308, 16);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(128, 28);
            this.searchLabel.TabIndex = 84;
            this.searchLabel.Text = "Search";
            this.searchLabel.Click += new System.EventHandler(this.searchLabel_Click);
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.weatherIcon);
            this.Controls.Add(this.outdoorLabel);
            this.Controls.Add(this.currentDate);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.tempLabel);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(465, 404);
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label currentDate;
        private System.Windows.Forms.Label outdoorLabel;
        private System.Windows.Forms.PictureBox weatherIcon;
        private System.Windows.Forms.Label searchLabel;
    }
}
