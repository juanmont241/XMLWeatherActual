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
    public partial class CurrentScreen : UserControl
    {
        //Make them all public static, so that they can used in another windows
        //The main lists for the background and icons
        public static List<Image> imageList = new List<Image>();
        public static List<Image> imageIcons = new List<Image>();

        //Main ints to round to the nearest decimal for each day
        public static int conditionCode = Convert.ToInt32(Form1.days[0].condition);
        public static int conditionCodeDay2 = Convert.ToInt32(Form1.days[1].condition);
        public static int conditionCodeDay3 = Convert.ToInt32(Form1.days[2].condition);

        public CurrentScreen()
        {
            InitializeComponent();

            //Declare the image background resources
            Image rainImage = Properties.Resources.Rainy;
            Image sunnyImage = Properties.Resources.Sunny;
            Image cloudyImage = Properties.Resources.Cloudy;
            Image snowyImage = Properties.Resources.Snowy;
            Image mistImage = Properties.Resources.Mist;
            Image thunderImage = Properties.Resources.Thunder;

            //Add them to the imageList
            imageList.Add(rainImage);
            imageList.Add(sunnyImage);
            imageList.Add(cloudyImage);
            imageList.Add(snowyImage);
            imageList.Add(mistImage);
            imageList.Add(thunderImage);

            //Declare the Icon resources
            Image rainIcon = Properties.Resources.Rainy_Icon;
            Image sunnyIcon = Properties.Resources.Sunny_Icon;
            Image cloudyIcon = Properties.Resources.Cloudy_Icon;
            Image snowyIcon = Properties.Resources.Snowy_icon;
            Image mistIcon = Properties.Resources.Mist_Icon;
            Image thunderIcon = Properties.Resources.Thunder_Icon;

            //Add them to the imageIcons List
            imageIcons.Add(rainIcon);
            imageIcons.Add(sunnyIcon);
            imageIcons.Add(cloudyIcon);
            imageIcons.Add(snowyIcon);
            imageIcons.Add(mistIcon);
            imageIcons.Add(thunderIcon);

            //Start the program
            DisplayCurrent();
            WeatherBackground();

        }

        public void DisplayCurrent()
        {

            // Round the max temperture and placed it on trueMax
            double tempDoubleMax = Convert.ToDouble(Form1.days[0].tempHigh);
            int roundMax = Convert.ToInt32(Math.Round(tempDoubleMax));
            roundMax = Form1.trueMax;

            // Round the min temperture and placed it on trueMix
            double tempDoubleMin = Convert.ToDouble(Form1.days[0].tempLow);
            int roundMin = Convert.ToInt32(Math.Round(tempDoubleMin));
            roundMin = Form1.trueMin;

            //Display the main data about Stratford
            cityOutput.Text = Form1.days[0].location; //City
            tempLabel.Text = Form1.trueInt + "°"; //Temperture (Rounded)
            weatherIcon.Text = Form1.days[0].condition; //Weather Icon
            outdoorLabel.Text = Form1.days[0].visibility; //What is the weather (ex: rain and snow)
            minOutput.Text = Form1.trueMin + "°"; //The min temperture (Rounded)
            maxOutput.Text = Form1.trueMax + "°"; //The max temperture (Rounded)
            currentDate.Text = Form1.days[0].date; //What day is it today
        }

        public void WeatherBackground()
        {
            //if the weather number is in a certain range, then changes the background to the fellow weather

            if (conditionCode >= 500 && conditionCode <= 531) //Raining
            {
                this.BackgroundImage = imageList[0]; //Changes the background to rain
                weatherIcon.Image = imageIcons[0]; //Changes the icon to rain

            }

            else if (conditionCode == 800) //Sunny
            {
                this.BackgroundImage = imageList[1];
                weatherIcon.Image = imageIcons[1];

            }

            else if (conditionCode >= 801 && conditionCode <= 804) //Cloudy
            {
                this.BackgroundImage = imageList[2];
                weatherIcon.Image = imageIcons[2];

            }

            else if (conditionCode >= 600 && conditionCode <= 622) //Snowy
            {
                this.BackgroundImage = imageList[3];
                weatherIcon.Image = imageIcons[3];

            }

            else if (conditionCode >= 701 && conditionCode <= 781) //Mist
            {
                this.BackgroundImage = imageList[4];
                weatherIcon.BackgroundImage = imageIcons[4];


            }

            else if (conditionCode >= 200 && conditionCode <= 232) //Thunder
            {
                this.BackgroundImage = imageList[5];
                weatherIcon.BackgroundImage = imageIcons[5];

            }

            Refresh();  //Refresh when finished

        }

        private void forecastLabel_Click(object sender, EventArgs e)
            //Button to send to the forecast window
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void searchLabel_Click(object sender, EventArgs e)
            //Button to send to the search window
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            SearchScreen ss = new SearchScreen();
            f.Controls.Add(ss);
        }
    }
}
