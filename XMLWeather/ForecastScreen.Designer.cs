namespace XMLWeather
{
    partial class ForecastScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForecastScreen));
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.minTemp2 = new System.Windows.Forms.Label();
            this.maxTemp2 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.date3 = new System.Windows.Forms.Label();
            this.minTemp3 = new System.Windows.Forms.Label();
            this.maxTemp3 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.minTemp1 = new System.Windows.Forms.Label();
            this.maxTemp1 = new System.Windows.Forms.Label();
            this.max1 = new System.Windows.Forms.Label();
            this.max2 = new System.Windows.Forms.Label();
            this.weatherIcon = new System.Windows.Forms.PictureBox();
            this.weatherIcon2 = new System.Windows.Forms.PictureBox();
            this.weatherIcon3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.IndianRed;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(110, 14);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(82, 28);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "7 Day";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 28);
            this.label3.TabIndex = 61;
            this.label3.Text = "Today";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // minTemp2
            // 
            this.minTemp2.AutoSize = true;
            this.minTemp2.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Underline);
            this.minTemp2.ForeColor = System.Drawing.Color.White;
            this.minTemp2.Location = new System.Drawing.Point(21, 251);
            this.minTemp2.Name = "minTemp2";
            this.minTemp2.Size = new System.Drawing.Size(234, 31);
            this.minTemp2.TabIndex = 46;
            this.minTemp2.Text = " Min Temperature";
            // 
            // maxTemp2
            // 
            this.maxTemp2.AutoSize = true;
            this.maxTemp2.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Underline);
            this.maxTemp2.ForeColor = System.Drawing.Color.White;
            this.maxTemp2.Location = new System.Drawing.Point(21, 220);
            this.maxTemp2.Name = "maxTemp2";
            this.maxTemp2.Size = new System.Drawing.Size(233, 31);
            this.maxTemp2.TabIndex = 44;
            this.maxTemp2.Text = "Max Temperature";
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Underline);
            this.date2.ForeColor = System.Drawing.Color.White;
            this.date2.Location = new System.Drawing.Point(13, 178);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(71, 31);
            this.date2.TabIndex = 64;
            this.date2.Text = "Date";
            // 
            // date3
            // 
            this.date3.AutoSize = true;
            this.date3.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Underline);
            this.date3.ForeColor = System.Drawing.Color.White;
            this.date3.Location = new System.Drawing.Point(13, 284);
            this.date3.Name = "date3";
            this.date3.Size = new System.Drawing.Size(71, 31);
            this.date3.TabIndex = 69;
            this.date3.Text = "Date";
            // 
            // minTemp3
            // 
            this.minTemp3.AutoSize = true;
            this.minTemp3.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Underline);
            this.minTemp3.ForeColor = System.Drawing.Color.White;
            this.minTemp3.Location = new System.Drawing.Point(19, 355);
            this.minTemp3.Name = "minTemp3";
            this.minTemp3.Size = new System.Drawing.Size(234, 31);
            this.minTemp3.TabIndex = 67;
            this.minTemp3.Text = " Min Temperature";
            // 
            // maxTemp3
            // 
            this.maxTemp3.AutoSize = true;
            this.maxTemp3.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Underline);
            this.maxTemp3.ForeColor = System.Drawing.Color.White;
            this.maxTemp3.Location = new System.Drawing.Point(20, 324);
            this.maxTemp3.Name = "maxTemp3";
            this.maxTemp3.Size = new System.Drawing.Size(233, 31);
            this.maxTemp3.TabIndex = 65;
            this.maxTemp3.Text = "Max Temperature";
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Underline);
            this.date1.ForeColor = System.Drawing.Color.White;
            this.date1.Location = new System.Drawing.Point(15, 65);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(71, 31);
            this.date1.TabIndex = 72;
            this.date1.Text = "Date";
            // 
            // minTemp1
            // 
            this.minTemp1.AutoSize = true;
            this.minTemp1.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Underline);
            this.minTemp1.ForeColor = System.Drawing.Color.White;
            this.minTemp1.Location = new System.Drawing.Point(13, 136);
            this.minTemp1.Name = "minTemp1";
            this.minTemp1.Size = new System.Drawing.Size(234, 31);
            this.minTemp1.TabIndex = 71;
            this.minTemp1.Text = " Min Temperature";
            // 
            // maxTemp1
            // 
            this.maxTemp1.AutoSize = true;
            this.maxTemp1.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Underline);
            this.maxTemp1.ForeColor = System.Drawing.Color.White;
            this.maxTemp1.Location = new System.Drawing.Point(21, 105);
            this.maxTemp1.Name = "maxTemp1";
            this.maxTemp1.Size = new System.Drawing.Size(233, 31);
            this.maxTemp1.TabIndex = 70;
            this.maxTemp1.Text = "Max Temperature";
            // 
            // max1
            // 
            this.max1.AutoSize = true;
            this.max1.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Underline);
            this.max1.ForeColor = System.Drawing.Color.White;
            this.max1.Location = new System.Drawing.Point(21, 105);
            this.max1.Name = "max1";
            this.max1.Size = new System.Drawing.Size(0, 31);
            this.max1.TabIndex = 73;
            // 
            // max2
            // 
            this.max2.AutoSize = true;
            this.max2.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Underline);
            this.max2.ForeColor = System.Drawing.Color.White;
            this.max2.Location = new System.Drawing.Point(20, 209);
            this.max2.Name = "max2";
            this.max2.Size = new System.Drawing.Size(0, 31);
            this.max2.TabIndex = 75;
            // 
            // weatherIcon
            // 
            this.weatherIcon.BackColor = System.Drawing.Color.Transparent;
            this.weatherIcon.InitialImage = null;
            this.weatherIcon.Location = new System.Drawing.Point(204, 88);
            this.weatherIcon.Name = "weatherIcon";
            this.weatherIcon.Size = new System.Drawing.Size(124, 79);
            this.weatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weatherIcon.TabIndex = 79;
            this.weatherIcon.TabStop = false;
            // 
            // weatherIcon2
            // 
            this.weatherIcon2.BackColor = System.Drawing.Color.Transparent;
            this.weatherIcon2.InitialImage = null;
            this.weatherIcon2.Location = new System.Drawing.Point(204, 192);
            this.weatherIcon2.Name = "weatherIcon2";
            this.weatherIcon2.Size = new System.Drawing.Size(124, 79);
            this.weatherIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weatherIcon2.TabIndex = 80;
            this.weatherIcon2.TabStop = false;
            // 
            // weatherIcon3
            // 
            this.weatherIcon3.BackColor = System.Drawing.Color.Transparent;
            this.weatherIcon3.InitialImage = null;
            this.weatherIcon3.Location = new System.Drawing.Point(204, 298);
            this.weatherIcon3.Name = "weatherIcon3";
            this.weatherIcon3.Size = new System.Drawing.Size(124, 79);
            this.weatherIcon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weatherIcon3.TabIndex = 81;
            this.weatherIcon3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(341, -21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // searchLabel
            // 
            this.searchLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(219, 14);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(82, 28);
            this.searchLabel.TabIndex = 83;
            this.searchLabel.Text = "Search";
            this.searchLabel.Click += new System.EventHandler(this.searchLabel_Click);
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.weatherIcon3);
            this.Controls.Add(this.weatherIcon2);
            this.Controls.Add(this.weatherIcon);
            this.Controls.Add(this.max2);
            this.Controls.Add(this.max1);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.minTemp1);
            this.Controls.Add(this.maxTemp1);
            this.Controls.Add(this.date3);
            this.Controls.Add(this.minTemp3);
            this.Controls.Add(this.maxTemp3);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.minTemp2);
            this.Controls.Add(this.maxTemp2);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(465, 404);
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label minTemp2;
        private System.Windows.Forms.Label maxTemp2;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label date3;
        private System.Windows.Forms.Label minTemp3;
        private System.Windows.Forms.Label maxTemp3;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label minTemp1;
        private System.Windows.Forms.Label maxTemp1;
        private System.Windows.Forms.Label max1;
        private System.Windows.Forms.Label max2;
        private System.Windows.Forms.PictureBox weatherIcon;
        private System.Windows.Forms.PictureBox weatherIcon2;
        private System.Windows.Forms.PictureBox weatherIcon3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label searchLabel;
    }
}
