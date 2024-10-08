﻿using Aqua.EnumerableExtensions;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private SortedSet<string> allCurrencies;
        private bool netStatus = false;
        public FormCurrencies()
        {
            InitializeComponent();
            LoadCurrencies();
            setUpImagesAndIcons();

            // Check connectivity
            netStatus = NetworkStatus.IsConnectedToInternet();
            checkNetStatusAndUpdateUI();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!netStatus)
            {
                MessageBox.Show("Please connect to a network");
                return;
            }

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

                showConvertingStatusLabel();
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
                                string result = $"{amount} {baseCurrency} is equal to {convertedAmount:F2} {targetCurrency}";

                                lbResult.Text = result;
                                listBoxRecently.Items.Add(result);

                                // Save to file the recently converted currency

                                hideConvertingStatusLabel();
                                clearInputs();
                            }
                            else
                            {
                                MessageBox.Show("Please enter a valid number", "Input Error");
                                hideConvertingStatusLabel();
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Conversion rate for {targetCurrency} not found", "Error");
                            hideConvertingStatusLabel();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to retrieve data, check for Currecny misspellings", "Error");
                        hideConvertingStatusLabel();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
                hideConvertingStatusLabel();
            }
        }

        private async void LoadCurrencies()
        {
            try
            {
                labelLoading.Visible = true;
                string apiKey = "f42f1685feea33e8ed4d0b9d";
                string url = $"https://v6.exchangerate-api.com/v6/{apiKey}/latest/USD";

                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    JObject json = JObject.Parse(responseBody);

                    var currencies = json["conversion_rates"].ToObject<Dictionary<string, object>>().Keys;
                    SortedSet<string> sortedCurrencies = new SortedSet<string>(currencies);

                    // So that we can filter the currencies via searching
                    allCurrencies = sortedCurrencies;

                    listBoxCurrencies.Items.Clear();
                    foreach (var currency in sortedCurrencies)
                    {
                        listBoxCurrencies.Items.Add(currency);
                    }

                    labelLoading.Visible = false;
                }
                else
                {
                    MessageBox.Show("Failed to retrieve currency data", "Error");
                    labelLoading.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
                labelLoading.Visible = false;
            }
        }

        private void listBoxCurrencies_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxCurrencies.SelectedItem == null)
            {
                MessageBox.Show("Please make a selection");
                return;
            }

            if (counter == 1)
            {
                string currency = (string) listBoxCurrencies.SelectedItem;
                if (currency != null)
                {
                    textBoxFrom.Text = currency;
                    counter++;
                }
            } else if (counter == 2)
            {
                string currency = (string) listBoxCurrencies.SelectedItem;
                if (currency != null)
                {
                    textBoxTo.Text = currency;
                    counter = 1;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = textBoxSearch.Text.ToString().Trim().ToUpper();
            SortedSet<string> filteredCurrencies = new SortedSet<string>(allCurrencies.Where(s => s.Contains(query)));

            listBoxCurrencies.Items.Clear();
            foreach (var currency in filteredCurrencies)
            {
                listBoxCurrencies.Items.Add(currency);
            }
        }

        private void clearInputs()
        {
            textBoxFrom.Clear();
            textBoxTo.Clear();
            textBoxSearch.Clear();
            textBoxAmount.Clear();
        }

        public void saveToDataFile()
        {
            string relativePath = @"..\..\Data\recently.txt";
            string directoryPath = Path.GetDirectoryName(relativePath);

            if (!Directory.Exists(directoryPath)){
                Directory.CreateDirectory(directoryPath);
            }

            StringBuilder stringBuilder = new StringBuilder();

            for (int i=0;i< listBoxRecently.Items.Count; i++)
            {
                string line = (string) listBoxRecently.Items[i];
                stringBuilder.AppendLine(line);
            }

            File.WriteAllText(relativePath, stringBuilder.ToString());
        }

        public void readFromDataFile()
        {
            listBoxRecently.Items.Clear();

            string relativePath = @"..\..\Data\recently.txt";
            if (File.Exists(relativePath))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(relativePath))
                    {
                        string line;
                        while((line = sr.ReadLine()) != null)
                        {
                            listBoxRecently.Items.Add(line);
                        }
                    }

                } catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string item = (string) listBoxRecently.SelectedItem;
            if (item != null)
            {
                listBoxRecently.Items.Remove(item);
            }
            else
            {
                MessageBox.Show("Please select an item");
            }
            
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            if (listBoxRecently.Items.Count == 0)
            {
                MessageBox.Show("There is nothing to clear");
                return;
            }

            DialogResult res = MessageBox.Show("Are you sure you want to clear all recent conversions?", "Alert", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                listBoxRecently.Items.Clear();
                saveToDataFile();
            }
        }

        private void FormCurrencies_Load(object sender, EventArgs e)
        {
            // Reading the recently search currencies
            readFromDataFile();
        }

        private void FormCurrencies_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Saving the recently search currencies
            saveToDataFile();
        }

        private void setUpImagesAndIcons()
        {
            this.Icon = new Icon(@"..\..\Images\ic_logo_currency.ico");
            this.pictureBoxLogo.Image = Image.FromFile(@"..\..\Images\ic_logo_currency.png");
        }

        private void checkNetStatusAndUpdateUI()
        {
            if (netStatus)
            {
                labelStatus.Text = "Connected";
                labelStatus.ForeColor = Color.Green;
            }
            else
            {
                labelStatus.Text = "Not connected";
                labelStatus.ForeColor = Color.Red;
            }
        }

        private void showConvertingStatusLabel()
        {
            labelConverting.Visible = true;
        }

        private void hideConvertingStatusLabel()
        {
            labelConverting.Visible = false;
        }
    }
}
