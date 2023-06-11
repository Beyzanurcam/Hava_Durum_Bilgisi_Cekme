using System.Xml.Linq;

namespace stajbesgün
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            label2.Text = DateTime.Now.ToShortDateString();
            string api = "40a8516066b2e3e2b4acbd95cd73a291";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=ankara&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument hava = XDocument.Load(connection);
            var sicaklik = hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            label4.Text = sicaklik.ToString();
            var durum = hava.Descendants("weather").ElementAt(0).Attribute("value").Value;
            label9.Text = durum.ToString();
            var ruzgar = hava.Descendants("speed").ElementAt(0).Attribute("value").Value;
            label10.Text = ruzgar + " m/s";
            var nem = hava.Descendants("humidity").ElementAt(0).Attribute("value").Value;
            label11.Text = nem + " %";

        }


    }
}