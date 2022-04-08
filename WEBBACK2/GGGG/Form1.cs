using CheckCountDubl;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace GGGG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            string str = textBox1.Text;

            CountDubl count = new CountDubl();
            int res = count.Count(str);



            var url = "https://localhost:7002/Test";
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            using (var HttpClient = new HttpClient(httpClientHandler))
            {
                Test test = new Test
                {
                    id = 0,
                    Input = str,
                    Output = res
                };

                var newTestSerialized = JsonSerializer.Serialize(test);
                var stringContent = new StringContent(newTestSerialized, Encoding.UTF8, "application/json");
                var responce = await HttpClient.PostAsync(url, stringContent);


                var res2 = await HttpClient.GetAsync(url);
                var result = await res2.Content.ReadAsStringAsync();
                IEnumerable<Test> results = JsonConvert.DeserializeObject<IEnumerable<Test>>(result);
                var emp = res2.Content;
                dataGridView1.DataSource = results;
                textBox2.Text = res.ToString();





            }
        }

    }

    internal class Test
    {
        public int id { get; set; }
        public string Input { get; set; }
        public int Output { get; set; }
    }
}
