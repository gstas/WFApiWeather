using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFApiWeather
{
    public partial class MainForm : Form
    {
        public static string lastError = "";
        public static string weatherData = "";
        object[] obj;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            textBox_city.Text = "";

            GetWeatherData();
            if (lastError != "")
            {
                MessageBox.Show(lastError, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (weatherData != "")
                {
                    WeatherRoot currentWeather = JsonConvert.DeserializeObject<WeatherRoot>(weatherData);
                    MessageBox.Show("Данные загружены!", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox_city.Text = currentWeather.city.country + ", " + currentWeather.city.name;


                    foreach (List list in currentWeather.list)
                    {
                        obj = new object[] {
                            list.dt_txt,
                            list.main.temp_min,
                            list.main.temp_max,
                            list.main.pressure,
                            list.main.humidity,
                            list.clouds.all,
                            list.weather[0].main,
                            "" + Math.Round(list.wind.deg) + "°; " + Math.Round(list.wind.speed)
                        };
                        dgv.Rows.Add(obj);
                        obj = null;
                    }

                }
                else
                {
                    MessageBox.Show("Отсутствуют данные о погоде", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static void GetWeatherData()
        {

            lastError = "";
            WebClient client = new WebClient();
            try
            {
                using (Stream stream = client.OpenRead("https://api.openweathermap.org/data/2.5/forecast?q=Odessa,ua&appid=dac392b2d2745b3adf08ca26054d78c4&lang=ru&units=metric"))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        weatherData = reader.ReadToEnd();
                    }
                }

            }
            catch (Exception e)
            {
                lastError = e.Message;
            }
        }


    }
}
