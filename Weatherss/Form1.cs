using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace Weatherss
{
    public partial class Form1 : Form
    {
        private object jsonConvert;
        const string APPID = "e97b3f5aed905c5a49eb52ae7d3abd16";
        string cityID = "1566083";
        public Form1()
        {
            InitializeComponent();

            getWeather("1566083");
           //geForcast("1566083");
        }

        void getWeather(string city)
        {
            using(WebClient web = new WebClient())
            {
                string url = string.Format("http://api.openweathermap.org/data/2.5/weather?id={0}&appid={1}&units=metric&cnt=6", city, APPID);


                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                WeatherInfo.root outPut = result;
                lbl_textCity.Text = string.Format("{0}", outPut.name);
                lbl_Country.Text = string.Format("{0}", outPut.sys.country);
                lbl_DoCe.Text = string.Format("{0} \u00B0" +"C", outPut.main.temp) ;
            }    
        }

       /* void geForcast(string city)
        {
            int day = 2;
            string url = string.Format("http://api.openweathermap.org/data/2.5/forecast/weather?id={0}&units=metri&cnt={1}&appid={2}", city, day, APPID);
            using (WebClient web = new WebClient())
            {
                var json = web.DownloadString(url);
                var Object = JsonConvert.DeserializeObject<WeatherForcasts>(json);
                WeatherForcasts forcasts = Object;
                lbl_Conditions.Text = string.Format("{0}", forcasts.list[1].weather[0].main);
                lbl_Description.Text = string.Format("{0}", forcasts.list[1].weather[0].descriptions);
                lbl_Des2.Text = string.Format("{0} \u00B0" + "C", forcasts.list[1].temp);
                lbl_speed.Text = string.Format("{0}", forcasts.list[1].speed);
            }
        }*/
        private void lbl_textCity_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
