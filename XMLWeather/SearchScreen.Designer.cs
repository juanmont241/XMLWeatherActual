namespace XMLWeather
{
    partial class SearchScreen
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
            this.searchLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.searchCity = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.BackColor = System.Drawing.Color.IndianRed;
            this.searchLabel.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Underline);
            this.searchLabel.ForeColor = System.Drawing.Color.Black;
            this.searchLabel.Location = new System.Drawing.Point(310, 9);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(128, 28);
            this.searchLabel.TabIndex = 87;
            this.searchLabel.Text = "Search";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Underline);
            this.forecastLabel.ForeColor = System.Drawing.Color.Black;
            this.forecastLabel.Location = new System.Drawing.Point(175, 9);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(109, 50);
            this.forecastLabel.TabIndex = 86;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Underline);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 28);
            this.label3.TabIndex = 85;
            this.label3.Text = "Today";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.SystemColors.Info;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startButton.Location = new System.Drawing.Point(181, 261);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(79, 52);
            this.startButton.TabIndex = 88;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // searchCity
            // 
            this.searchCity.BackColor = System.Drawing.Color.Transparent;
            this.searchCity.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCity.ForeColor = System.Drawing.Color.Black;
            this.searchCity.Location = new System.Drawing.Point(40, 73);
            this.searchCity.Name = "searchCity";
            this.searchCity.Size = new System.Drawing.Size(422, 93);
            this.searchCity.TabIndex = 89;
            this.searchCity.Text = "Search City";
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(131, 192);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(174, 20);
            this.userInput.TabIndex = 90;
            // 
            // SearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.searchCity);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Name = "SearchScreen";
            this.Size = new System.Drawing.Size(465, 404);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label searchCity;
        private System.Windows.Forms.TextBox userInput;
    }
}
