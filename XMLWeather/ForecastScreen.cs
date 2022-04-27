using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            //----------------------- DAY 1 -----------------------//

            if (CurrentScreen.conditionCode >= 500 && CurrentScreen.conditionCode <= 531) //Raining (Numbers represent the weather)
            {
                weatherIcon.Image = CurrentScreen.imageIcons[0]; //Changes the image icon to the weather
            }

            else if (CurrentScreen.conditionCode == 800) //Sunny
            {
                weatherIcon.Image = CurrentScreen.imageIcons[1];
            }

            else if (CurrentScreen.conditionCode >= 801 && CurrentScreen.conditionCode <= 804) //Cloudy
            {
                weatherIcon.Image = CurrentScreen.imageIcons[2];
            }

            else if (CurrentScreen.conditionCode >= 600 && CurrentScreen.conditionCode <= 622) //Snowy
            {
                weatherIcon.Image = CurrentScreen.imageIcons[3];
            }

            else if (CurrentScreen.conditionCode >= 701 && CurrentScreen.conditionCode <= 781) //Mist
            {
                weatherIcon.Image = CurrentScreen.imageIcons[4];
            }

            else if (CurrentScreen.conditionCode >= 200 && CurrentScreen.conditionCode <= 232) //Thunder
            {
                weatherIcon.Image = CurrentScreen.imageIcons[5];
            }

            //Adds the respected date, rounded max, and min for each day in the Forecast
            date1.Text = Form1.days[1].date;
            double forDoubleMax = Convert.ToDouble(Form1.days[1].tempHigh);
            int forRoundMax = Convert.ToInt32(Math.Round(forDoubleMax));
            minTemp1.Text = forRoundMax + "°C";

            double forDoubleMin = Convert.ToDouble(Form1.days[1].tempLow);
            int forRoundMin = Convert.ToInt32(Math.Round(forDoubleMin));
            maxTemp1.Text = forRoundMin + "°C";


            //----------------------- DAY 2 -----------------------//

            if (CurrentScreen.conditionCodeDay2 >= 500 && CurrentScreen.conditionCodeDay2 <= 531) //Raining
            {
                weatherIcon.Image = CurrentScreen.imageIcons[0];
            }

            else if (CurrentScreen.conditionCodeDay2 == 800) //Sunny
            {
                weatherIcon2.Image = CurrentScreen.imageIcons[1];
            }

            else if (CurrentScreen.conditionCodeDay2 >= 801 && CurrentScreen.conditionCodeDay2 <= 804) //Cloudy
            {
                weatherIcon2.Image = CurrentScreen.imageIcons[2];
            }

            else if (CurrentScreen.conditionCodeDay2 >= 600 && CurrentScreen.conditionCodeDay2 <= 622) //Snowy
            {
                weatherIcon2.Image = CurrentScreen.imageIcons[3];
            }

            else if (CurrentScreen.conditionCodeDay2 >= 701 && CurrentScreen.conditionCodeDay2 <= 781) //Mist
            {
                weatherIcon2.Image = CurrentScreen.imageIcons[4];
            }

            else if (CurrentScreen.conditionCodeDay2 >= 200 && CurrentScreen.conditionCodeDay2 <= 232) //Thunder
            {
                weatherIcon2.Image = CurrentScreen.imageIcons[5];
            }
            date2.Text = Form1.days[2].date;

            double forDoubleMax2 = Convert.ToDouble(Form1.days[2].tempHigh);
            int forRoundMax2 = Convert.ToInt32(Math.Round(forDoubleMax2));
            minTemp2.Text = forRoundMax2 + "°C";

            double forDoubleMin2 = Convert.ToDouble(Form1.days[2].tempLow);
            int forRoundMin2 = Convert.ToInt32(Math.Round(forDoubleMin2));
            maxTemp2.Text = forRoundMin2 + "°C";

            //----------------------- DAY 3 -----------------------//

            if (CurrentScreen.conditionCodeDay3 >= 500 && CurrentScreen.conditionCodeDay3 <= 531) //Raining
            {
                weatherIcon3.Image = CurrentScreen.imageIcons[0];
            }

            else if (CurrentScreen.conditionCodeDay3 == 800) //Sunny
            {
                weatherIcon3.Image = CurrentScreen.imageIcons[1];
            }

            else if (CurrentScreen.conditionCodeDay3 >= 801 && CurrentScreen.conditionCodeDay3 <= 804) //Cloudy
            {
                weatherIcon3.Image = CurrentScreen.imageIcons[2];
            }

            else if (CurrentScreen.conditionCodeDay3 >= 600 && CurrentScreen.conditionCodeDay3 <= 622) //Snowy
            {
                weatherIcon3.Image = CurrentScreen.imageIcons[3];
            }

            else if (CurrentScreen.conditionCodeDay3 >= 701 && CurrentScreen.conditionCodeDay3 <= 781) //Mist
            {
                weatherIcon3.Image = CurrentScreen.imageIcons[4];
            }

            else if (CurrentScreen.conditionCodeDay3 >= 200 && CurrentScreen.conditionCodeDay3 <= 232) //Thunder
            {
                weatherIcon3.Image = CurrentScreen.imageIcons[5];
            }
            date3.Text = Form1.days[3].date;
            
            double forDoubleMax3 = Convert.ToDouble(Form1.days[3].tempHigh);
            int forRoundMax3 = Convert.ToInt32(Math.Round(forDoubleMax3));
            minTemp3.Text = forRoundMax3 + "°C";

            double forDoubleMin3 = Convert.ToDouble(Form1.days[3].tempLow);
            int forRoundMin3 = Convert.ToInt32(Math.Round(forDoubleMin3));
            maxTemp3.Text = forRoundMin3 + "°C";
        }


        private void label3_Click(object sender, EventArgs e) //When clicked, sends to currentscreen
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void searchLabel_Click(object sender, EventArgs e) //When clicked, sends to searchscreen
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            SearchScreen ss = new SearchScreen();
            f.Controls.Add(ss);
        }
    }
}
