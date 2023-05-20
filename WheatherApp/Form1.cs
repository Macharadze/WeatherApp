
using Newtonsoft.Json;
using System.Net;
using System.Timers;
using System.Threading;

namespace WheatherApp
{
    public partial class Form1 : Form
    {
        static int i = 0;
        Thread th1;

        public Form1()
        {
            InitializeComponent();
            var timer = new System.Timers.Timer();
            timer.Interval = 500;
            timer.Elapsed += onTime;
            timer.Start();


        }
        string APIKey = "aef835f6e5760d35f7a3021bc508a80e";



        private void btnSearch_Click(object sender, EventArgs e)
        {
            getWeather();
        }
        void getWeather()
        {

            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TBCity.Text, APIKey);
                var json = web.DownloadString(url);
                wheatherInfo.root info = JsonConvert.DeserializeObject<wheatherInfo.root>(json);
                picBox.ImageLocation = "https://api.openweathermap.org/img/w/" + info.weather[0].icon + ".png";
                labCordition.Text = info.weather[0].main;
                labDetails.Text = info.weather[0].description;
                labSunrise.Text = Math.Round((info.main.temp - 273.15), 2).ToString();
                labSunSet.Text = Math.Round((info.main.feels_like - 273.15), 2).ToString();
                labSpeed.Text = info.wind.speed.ToString();
                labPressire.Text = info.main.pressure.ToString();

            }
        }
        void timer_M()
        {
            this.Invoke(() =>
            {
                sec.Text = DateTime.Now.ToString("ss");
                time.Text = DateTime.Now.ToString("HH:mm");
            });

        }
        void onTime(object sender, ElapsedEventArgs e)
        {
            th1 = new Thread(new ThreadStart(timer_M));
            th1.Start();
        }

        private void time_Click(object sender, EventArgs e)
        {

        }
    }
}