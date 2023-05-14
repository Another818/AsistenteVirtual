using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Net;
using System.Text;

namespace Asistente_virtual
{
    public partial class frmClima : Form
    {
        string Evento = "loc";
        //Creo el objeto de la clase Clima()
        clsClima myClima = new clsClima();
        //
        clsLocationData location = new clsLocationData();
        public frmClima()
        {
            InitializeComponent();
        }

        private void frmClima_Load(object sender, EventArgs e)
        {
            btnBuscar.PerformClick();
            switch (Evento)
            {
                case "loc":
                    lblCiudad.Visible = false;
                    lblPais.Visible = false;
                    txtbCiudad.Visible = false;
                    txtbPais.Visible = false;
                    btnBuscar.Visible = false;
                    btnBusqueda.Visible = true;
                    break;
                case "busc":
                    lblCiudad.Visible = true;
                    lblPais.Visible = true;
                    txtbCiudad.Visible = true;
                    txtbPais.Visible = true;
                    btnBuscar.Visible = true;
                    btnBusqueda.Visible = false;
                    break;
            }

        }

        public clsLocationData GetGeolocation()
        {
            try
            {
                clsLocationData locationData = new clsLocationData();
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://ipapi.co/json/");
                request.UserAgent = "ipapi.co/#c-sharp-v1.03";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                var reader = new System.IO.StreamReader(response.GetResponseStream(), UTF8Encoding.UTF8);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string jsonResponse = reader.ReadToEnd();

                    locationData = JsonConvert.DeserializeObject<clsLocationData>(jsonResponse);

                }
                else if (response.StatusCode == System.Net.HttpStatusCode.TooManyRequests)
                {
                    Evento = "busc";
                    locationData = null;
                }

                return locationData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Evento = "busc";
                return null;
            }
        }

        public void GetTemperature(string city, string country)
        {
            try
            {
                clsLocationData location = GetGeolocation();
                string apiKey = "TuApiKey";
                var client = new RestClient("https://api.openweathermap.org");
                var request = new RestRequest("data/2.5/weather", Method.Get);
                switch (Evento)
                {
                    case "loc":
                        request.AddParameter("q", $"{location.city},{location.country_name}");
                        break;
                    case "busc":
                        request.AddParameter("q", $"{city}, {country}");
                        break;
                }

                request.AddParameter("appid", apiKey);

                var response = client.Execute(request);
                var responseJson = JObject.Parse(response.Content);

                var temperature = double.Parse(responseJson["main"]["temp"].ToString());
                var sensacion = double.Parse(responseJson["main"]["feels_like"].ToString());
                var temp_min = double.Parse(responseJson["main"]["temp_min"].ToString());
                var temp_max = double.Parse(responseJson["main"]["temp_max"].ToString());
                var presion = int.Parse(responseJson["main"]["pressure"].ToString());
                var humedad = int.Parse(responseJson["main"]["humidity"].ToString());
                string pais = responseJson["sys"]["country"].ToString();
                string ciudad = responseJson["name"].ToString();

                myClima.pDTemperatura = temperature;
                myClima.pDSensacion = sensacion;
                myClima.pDTemp_Min = temp_min;
                myClima.pDTemp_Max = temp_max;
                myClima.pIPresion = presion;
                myClima.pIHumedad = humedad;
                myClima.pSPais = pais;
                myClima.pSName = ciudad;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kelvin = 273.15;
            GetTemperature(txtbCiudad.Text, txtbPais.Text);
            var temperatureCel = Convert.ToString(Math.Round(myClima.pDTemperatura - kelvin));
            var sensacionter = Convert.ToString(Math.Round(myClima.pDSensacion - kelvin));
            var temp_max = Convert.ToString(Math.Round(myClima.pDTemp_Max - kelvin));
            var temp_min = Convert.ToString(Math.Round(myClima.pDTemp_Min - kelvin));
            lblTemp.Text = $"{temperatureCel}°C";
            lblSensacion.Text = $"Sensación térmica: {sensacionter}°";
            lblMax.Text = $"Max: {temp_max}°";
            lblMin.Text = $"Min: {temp_min}°";
            lblPresion.Text = $"Presión: {myClima.pIPresion} mbar";
            lblHumedad.Text = $"Humedad: {myClima.pIHumedad}%";
            lblDatos.Text = $"{myClima.pSName}, {myClima.pSPais}";
            lblHora.Text = $"{DateTime.Now}";
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            Evento = "busc";
            lblCiudad.Visible = true;
            lblPais.Visible = true;
            txtbCiudad.Visible = true;
            txtbPais.Visible = true;
            btnBuscar.Visible = true;
        }
    }
}
