using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MirraMirraForms
{
    public partial class Form1 : Form
    {
        private compliment displayCompliment = new compliment();
        private weather currentWeather = new weather();
        private Dictionary<string, string> currentConditions = new Dictionary<string, string>();
        private weather Weather = new weather();

        public Form1()
        {
            InitializeComponent();
            complimentLabel.Text = displayCompliment.getCompliment();

            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }



        private void secondTimer_Tick_1(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("h:mm tt");
            dateLabel.Text = DateTime.Today.ToString("ddd d MMM yyyy");

        }


        private void MinuteTimer_Tick_1(object sender, EventArgs e)
        {
            currentConditions = Weather.getCurrentWeather();
            complimentLabel.Text = displayCompliment.getCompliment();
            weather1.Text = currentConditions["//weather"];
            weather2.Text = (Convert.ToString(Convert.ToInt32((double.Parse(currentConditions["//temperature"]) - 32) * ((double)5 / (double)9))) + "°C");//converts fahreinheit to celsius
            weather3.Text = (currentConditions["//clouds"]);

        }

        private void timeLabel_Click(object sender, EventArgs e)
        {
        ///nothing but if i delete this forms designer will hate me and delete my lifes work
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            /////////nothing again
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;

        }

    }



        //Non Gui Code

        class compliment
        {
            //attributes
            private string[] compliments = new string[5] { "You Look Nice Today", "Hello Sexy!", "You're The Best", "There's Something In Your Teeth", "You're The Fairest Of Them All" };
            private Random rnd = new Random();

            //methods
            public string getCompliment()
            {
                int randomNum = rnd.Next(0, 5);
                return compliments[randomNum];
            }

        }

        class weather
        {

            //attributes
            private const string API_KEY = "insert a key here" ;//api key for open weather map org
            private const string CurrentUrl = "http://api.openweathermap.org/data/2.5/weather?" + "q=@LOC@&mode=xml&units=imperial&APPID=" + API_KEY;//replace @loc@ with location
            private string location = "Ely, UK";
            private Dictionary<string, string> weatherConditionsDict = new Dictionary<string, string>();

            //methods

            public Dictionary<string, string> getCurrentWeather()
            {
                // Compose the query URL.
                string url = CurrentUrl.Replace("@LOC@", location);
                XmlDocument weatherConditions = getXML(url);
                setWeather(weatherConditions);
                return weatherConditionsDict;

            }

            // Return the XML result of the URL.
            public XmlDocument getXML(string url)
            {
                using (WebClient client = new WebClient())
                {
                    string xmlContent = client.DownloadString(url);
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(xmlContent);
                    return xmlDocument;
                }
            }

            //get the weather conditions in a dictionary
            public void setWeather(XmlDocument weatherConditions)
            {
                weatherConditionsDict.Clear();
                string[] items = new string[3] { "//weather", "//temperature", "//clouds" };
                string[] values = new string[3] { "value", "value", "name" };
                for (int a = 0; a < 3; a += 1)
                {
                    XmlNode temp_node = weatherConditions.SelectSingleNode(items[a]);
                    XmlAttribute temp_value = temp_node.Attributes[values[a]];
                    string temp_string = temp_value.Value;
                    weatherConditionsDict.Add(items[a], temp_string);
                }

            }

        }

        class redditNews
        {

        }


        class phoneNotifications
        {

        }

        class calendar
        {

        }

       
    
}





/////////////////////////////////////////////
