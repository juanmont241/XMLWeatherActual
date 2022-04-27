using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // Creates a list to hold day objects
        public static List<Day> days = new List<Day>();

        //Creating user's input city url
        public static string urlCity;

        //Creates "public static" variables for rounded tempertures
        public static int trueInt, trueMax, trueMin;

        public Form1()
        {
            //Starts the code
            InitializeComponent();
            ExtractForecast();
            ExtractCurrent();

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        public static void ExtractForecast() //Finds all the data from the website link to find each required data
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                // Create a day object
                Day newDay = new Day();

                //Fill day object with required data 

                //Find the date of today
                reader.ReadToFollowing("time"); 
                newDay.date = reader.GetAttribute("day");

                //Find the current weather number and the weather's name
                reader.ReadToFollowing("symbol");
                newDay.condition = reader.GetAttribute("number");
                newDay.visibility = reader.GetAttribute("name");

                //Find the current max and min temperature and add to appropriate item in days list
                reader.ReadToFollowing("temperature");
                newDay.tempLow = reader.GetAttribute("min");
                newDay.tempHigh = reader.GetAttribute("max");

                //Round the max temperture and placed it on trueMax
                //double tempDoubleMax = Convert.ToDouble(days[0].tempHigh);
                //int roundMax = Convert.ToInt32(Math.Round(tempDoubleMax));
                //roundMax = trueMax;

                //Round the min temperture and placed it on trueMix
                //double tempDoubleMin = Convert.ToDouble(days[0].tempLow);
                //int roundMin = Convert.ToInt32(Math.Round(tempDoubleMin));
                //roundMin = trueMin;

                //if day object not null add to the days list
                if (newDay.date != null)
                {
                    days.Add(newDay);
                }

            }
        }

        public static void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //Find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            //Find the current temperature
            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");

            //Round the temperture and placed it on trueInt
            double tempDouble = Convert.ToDouble(days[0].currentTemp);
            int temp = Convert.ToInt32(Math.Round(tempDouble));
            temp = trueInt;
        }

        //------------------Searching New City-----------------//

        //Find the city's file by changing the city's name in the url 
        public static void ExtractSearchForcast()
        {
                XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=" + urlCity + "&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

               //Fill day object with required data 

               //Finds the new city's name
               reader.ReadToFollowing("city");
               days[0].location = reader.GetAttribute("name");

                //Find the current max, min, and current temperature and add to appropriate item in days list
                reader.ReadToFollowing("temperature");
                days[0].currentTemp = reader.GetAttribute("value");
                days[0].tempLow = reader.GetAttribute("min");
                days[0].tempHigh = reader.GetAttribute("max");

                ////Round the max temperture and placed it on trueMax
                //double tempDoubleMax = Convert.ToDouble(days[0].tempHigh);
                //int roundMax = Convert.ToInt32(Math.Round(tempDoubleMax));
                //roundMax = trueMax;

                ////Round the min temperture and placed it on trueMix
                //double tempDoubleMin = Convert.ToDouble(days[0].tempLow);
                //int roundMin = Convert.ToInt32(Math.Round(tempDoubleMin));
                //roundMin = trueMin;
            }

        }
    }

//Remember to Ask:
//System.ArgumentOutOfRangeException: (Both Search Bar, and tempHigh round)
//Search bar