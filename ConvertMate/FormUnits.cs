using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertMate
{
    public partial class FormUnits : Form
    {
        private HttpClient client = new HttpClient();
        public FormUnits()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Define the API endpoint and parameters
                string url = "https://unitconvert.io/api/convert?from=meters&to=feet&value=1";

                // Send a request to the API
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                // Read and parse the response
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(responseBody);

                MessageBox.Show($"Converted value: {json["value"]}");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Request error: {ex.Message}");
            }
        }
    }
}
