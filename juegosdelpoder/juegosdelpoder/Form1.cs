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
using System.Collections.Concurrent;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace juegosdelpoder
{
    public partial class FormJDP : Form
    {
        public List<String> clasesDejuego = new List<String>();
        public FormJDP()
        {
            InitializeComponent();
        }

        private void FormJDP_Load(object sender, EventArgs e)
        { 
            Get();
        }

        private void botonJugar_Click(object sender, EventArgs e)
        {
            Form2 personajeformu = new Form2();
            personajeformu.ShowDialog();
            this.Close();
        }

        private void botonSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       public void Get()
        {
            var url = $"https://www.dnd5eapi.co/api/races";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objectReader = new StreamReader(strReader))
                        {
                            string responseBody = objectReader.ReadToEnd();
                            Clases myListadeClass = JsonSerializer.Deserialize<Clases>(responseBody);
                            foreach (Result Re in myListadeClass.Results)
                            {
                               listBox1.Items.Add(Re.Name);
                            }
                            
                        }
                    }

                }
               
                
            }
            catch (WebException ex)
            {
                //handle error
            }

        }
      
        // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
        public class Result
        {
            [JsonPropertyName("index")]
            public string Index { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("url")]
            public string Url { get; set; }
        }

        public class Clases
        {
            [JsonPropertyName("count")]
            public int Count { get; set; }

            [JsonPropertyName("results")]
            public List<Result> Results { get; set; }
        }

       
    }


}
