using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class SearchScreen : UserControl
    {
        public SearchScreen()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e) //Send to CurrentScreen when clicked
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void forecastLabel_Click(object sender, EventArgs e) //Send to ForecastScreen when clicked
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void startButton_Click(object sender, EventArgs e) //Starts finding the city from the user's input
        {
            Form1.urlCity = userInput.Text; //user input of their city (Has to be written like this: Stratford,CA)
         //   Form1.days.Clear(); //Clears the days list

            //Does the Forecast and Current functions again for the new city
            Form1.ExtractSearchForcast();

            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen fs = new CurrentScreen(); //Sends to the CurrentScreen to see the new city's results
            f.Controls.Add(fs);

        }


    }
}
