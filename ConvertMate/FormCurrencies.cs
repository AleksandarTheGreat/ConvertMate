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
    public partial class FormCurrencies : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private static int counter = 1;
        public FormCurrencies()
        {
            InitializeComponent();
            LoadCurrencies();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            calculate();
        }

        public async void calculate()
        {
            try
            {
                string apiKey = "f42f1685feea33e8ed4d0b9d";
                string baseCurrency = textBoxFrom.Text.ToUpper();
                string targetCurrency = textBoxTo.Text.ToUpper();
                string amountText = textBoxAmount.Text;

                if (string.IsNullOrEmpty(baseCurrency) || string.IsNullOrEmpty(targetCurrency) || string.IsNullOrEmpty(amountText))
                {
                    MessageBox.Show("Please fill in all fields", "Input Error");
                    return;
                }

                // Construct URL for the API request
                string url = $"https://v6.exchangerate-api.com/v6/{apiKey}/latest/{baseCurrency}";

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        JObject json = JObject.Parse(responseBody);

                        if (json["conversion_rates"]?[targetCurrency] != null)
                        {
                            decimal conversionRate = json["conversion_rates"][targetCurrency].Value<decimal>();

                            if (decimal.TryParse(amountText, out decimal amount))
                            {
                                decimal convertedAmount = amount * conversionRate;
                                lbResult.Text = $"{amount} {baseCurrency} is equal to {convertedAmount:F2} {targetCurrency}";
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid number", "Input Error");
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Conversion rate for {targetCurrency} not found", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve data", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
        }

        private async void LoadCurrencies()
        {
            try
            {
                string apiKey = "f42f1685feea33e8ed4d0b9d";
                string url = $"https://v6.exchangerate-api.com/v6/{apiKey}/latest/USD";

                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    JObject json = JObject.Parse(responseBody);

                    var currencies = json["conversion_rates"].ToObject<Dictionary<string, object>>().Keys;
                    var sortedCurrencies = new SortedSet<string>(currencies);

                    listBoxCurrencies.Items.Clear();
                    foreach (var currency in sortedCurrencies)
                    {
                        listBoxCurrencies.Items.Add(currency);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to retrieve currency data", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
        }

        private void btnMoveToFrom_Click(object sender, EventArgs e)
        {
            if (listBoxCurrencies.SelectedIndex != -1)
            {
                string currecny = listBoxCurrencies.SelectedItem.ToString();
                textBoxFrom.Text = currecny;
            }
            else
            {
                MessageBox.Show("Please select a currency");
            }
        }

        private void btnMoveToTo_Click(object sender, EventArgs e)
        {
            if (listBoxCurrencies.SelectedIndex != -1)
            {
                string currecny = listBoxCurrencies.SelectedItem.ToString();
                textBoxTo.Text = currecny;
            }
            else
            {
                MessageBox.Show("Please select a currency");
            }
        }

        private void listBoxCurrencies_DoubleClick(object sender, EventArgs e)
        {
            if (counter == 1)
            {
                string currency = listBoxCurrencies.SelectedItem.ToString();
                textBoxFrom.Text = currency;
                counter++;
            } else if (counter == 2)
            {
                string currency = listBoxCurrencies.SelectedItem.ToString();
                textBoxTo.Text = currency;
                counter = 1;
            }
        }
    }
}
