using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace TestTilXamen
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Oppgave1();
            Oppgave2();
            Oppgave3();
            string startString = "Spiser boller og brus fra rema.";
            string omvendtString = Oppgave14(startString);
            resultatLabel.Text = omvendtString;
        }
       
        public int Oppgave1()
        {
            //http://jsonviewer.stack.hu/
            //https://peterdaugaardrasmussen.com/2022/01/18/how-to-get-a-property-from-json-using-selecttoken/
            //create the httpwebrequest
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.met.no/weatherapi/nowcast/2.0/complete?lat=59.9333&lon=10.7166");

            //the usual stuff. run the request, parse your json
            try
            {
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";
                httpWebRequest.UserAgent = "bolle";
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    JObject jObj = JObject.Parse(result);
                    JToken data = jObj.SelectToken("properties.timeseries[0].data.instant.details");


                    double temp = data.Value<double>("air_temperature");
                    LabelAirTemp.Text=temp.ToString();




                    //key name - getting key.value
                    //int valuepm25 = data.Value<int>("pm25");
                    //int radonValue = data.Value<int>("radonShortTermAvg");
                    // inn i db

                }
                return 0;
            }
            catch { Exception ex; }
            return 0;
        }



        public int Oppgave2()
        {
            //http://jsonviewer.stack.hu/
            //https://peterdaugaardrasmussen.com/2022/01/18/how-to-get-a-property-from-json-using-selecttoken/
            //create the httpwebrequest
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.met.no/weatherapi/nowcast/2.0/complete?lat=59.9333&lon=10.7166");

            //the usual stuff. run the request, parse your json
            try
            {
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";
                httpWebRequest.UserAgent = "bolle";
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    JObject jObj = JObject.Parse(result);
                    JToken data = jObj.SelectToken("properties.timeseries[0].data.instant.details");


                    double speed = data.Value<double>("wind_speed");
                    LabelAirSpeed.Text = speed.ToString();




                    //key name - getting key.value
                    //int valuepm25 = data.Value<int>("pm25");
                    //int radonValue = data.Value<int>("radonShortTermAvg");
                    // inn i db

                }
                return 0;
            }
            catch { Exception ex; }
            return 0;
        }



        public int Oppgave3()
        {
            //http://jsonviewer.stack.hu/
            //https://peterdaugaardrasmussen.com/2022/01/18/how-to-get-a-property-from-json-using-selecttoken/
            //create the httpwebrequest
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://api.met.no/weatherapi/nowcast/2.0/complete?lat=59.9333&lon=10.7166");

            //the usual stuff. run the request, parse your json
            try
            {
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";
                httpWebRequest.UserAgent = "bolle";
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    JObject jObj = JObject.Parse(result);
                    JToken data = jObj.SelectToken("properties.timeseries[0].data.instant.details");


                    double direction = data.Value<double>("wind_from_direction");
                    LabelWindDirection.Text = direction.ToString();




                    //key name - getting key.value
                    //int valuepm25 = data.Value<int>("pm25");
                    //int radonValue = data.Value<int>("radonShortTermAvg");
                    // inn i db

                }
                return 0;
            }
            catch { Exception ex; }
            return 0;
        }



        public static string Oppgave14(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}