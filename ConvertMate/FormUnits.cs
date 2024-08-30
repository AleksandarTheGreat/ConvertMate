using Aqua.EnumerableExtensions;
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
        public UnitGroup unitGroupDistance { get; set; }
        public UnitGroup unitGroupTemperature { get; set; }
        public UnitGroup unitGroupMass { get; set; }
        public UnitGroup unitGroupVolume { get; set; }
        public UnitGroup unitGroupTime { get; set; }
        private int counter = 1;
        private string type = "";

        public FormUnits()
        {
            InitializeComponent();
            setUpUnitGroups();
            listBoxMeasurments.Items.Clear();
            foreach (Unit unit in unitGroupDistance.unitsList)
            {
                listBoxMeasurments.Items.Add(unit);
            }
        }

        public async void loadMeasurementUnits()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://measurement-unit-converter.p.rapidapi.com/length/units"),
                Headers =
                {
                    { "x-rapidapi-key", "e038cee021msh9bb6e855b6f66dbp1ffd84jsn311270b306ce" },
                    { "x-rapidapi-host", "measurement-unit-converter.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
                MessageBox.Show(body);
            }
        }

        public void setUpUnitGroups()
        {
            List<Unit> list = new List<Unit>();
            list.Add(new Unit("Meter", "m"));
            list.Add(new Unit("Kilometer", "km"));
            list.Add(new Unit("Mile", "mi"));
            list.Add(new Unit("Yard", "yd"));
            list.Add(new Unit("Foot", "ft"));
            unitGroupDistance = new UnitGroup(list);

            list = new List<Unit>();
            list.Add(new Unit("Celsius", "°C"));
            list.Add(new Unit("Fahrenheit", "°F"));
            list.Add(new Unit("Kelvin", "K"));
            list.Add(new Unit("Rankine", "°R"));
            unitGroupTemperature = new UnitGroup(list);

            list = new List<Unit>();
            list.Add(new Unit("Gram", "g"));
            list.Add(new Unit("Kilogram", "kg"));
            list.Add(new Unit("Pound", "lb"));
            list.Add(new Unit("Ounce", "oz"));
            list.Add(new Unit("Ton", "t"));
            unitGroupMass = new UnitGroup(list);

            list = new List<Unit>();
            list.Add(new Unit("Liter", "l"));
            list.Add(new Unit("Milliliter", "ml"));
            list.Add(new Unit("Gallon", "gal"));
            list.Add(new Unit("Quart", "qt"));
            unitGroupVolume = new UnitGroup(list);

            list = new List<Unit>();
            list.Add(new Unit("Second ", "s"));
            list.Add(new Unit("Minute", "min"));
            list.Add(new Unit("Hour", "h"));
            list.Add(new Unit("Day", "d"));
            list.Add(new Unit("Week", "wk"));
            list.Add(new Unit("Month", "mo"));
            list.Add(new Unit("Year", "yr"));
            unitGroupTime = new UnitGroup(list);
        }

        private void buttonDistance_Click(object sender, EventArgs e)
        {
            type = "distance";
            listBoxMeasurments.Items.Clear();
            foreach(Unit unit in unitGroupDistance.unitsList)
            {
                listBoxMeasurments.Items.Add(unit);
            }
        }

        private void buttonTemperature_Click(object sender, EventArgs e)
        {
            type = "temperature";
            listBoxMeasurments.Items.Clear();
            foreach (Unit unit in unitGroupTemperature.unitsList)
            {
                listBoxMeasurments.Items.Add(unit);
            }
            clearInputs();
        }

        private void buttonMass_Click(object sender, EventArgs e)
        {
            type = "mass";
            listBoxMeasurments.Items.Clear();
            foreach (Unit unit in unitGroupMass.unitsList)
            {
                listBoxMeasurments.Items.Add(unit);
            }
            clearInputs();
        }

        private void buttonVolume_Click(object sender, EventArgs e)
        {
            type = "volume";
            listBoxMeasurments.Items.Clear();
            foreach (Unit unit in unitGroupVolume.unitsList)
            {
                listBoxMeasurments.Items.Add(unit);
            }
            clearInputs();
        }

        private void buttonTime_Click(object sender, EventArgs e)
        {
            type = "time";
            listBoxMeasurments.Items.Clear();
            foreach (Unit unit in unitGroupTime.unitsList)
            {
                listBoxMeasurments.Items.Add(unit);
            }
            clearInputs();
        }

        private void listBoxMeasurments_DoubleClick(object sender, EventArgs e)
        {
            if (counter == 1)
            {
                string unit = listBoxMeasurments.SelectedItem.ToString();
                string[] parts = unit.Split(' ');
                textBoxFrom.Text = parts[1];
                counter++;
            }
            else
            {
                string unit = listBoxMeasurments.SelectedItem.ToString();
                string[] parts = unit.Split(' ');
                textBoxTo.Text = parts[1];
                counter = 1;
            }
        }

        private async void buttonCalculate_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case "distance":
                    {
                        distanceRequest();
                        break;
                    }
                case "temperature":
                    {
                        temperatureConvertor();
                        break;
                    }
                case "mass":
                    {
                        massConvertor(); 
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Not ready yet");
                        break;
                    }
            }
        }
        // Distance API call
        public async void distanceRequest()
        {
            string fromUnit = textBoxFrom.Text.ToString();
            string toUnit = textBoxTo.Text.ToString();
            string amount = textBoxAmount.Text.ToString();

            if (fromUnit.IsNullOrEmpty() || toUnit.IsNullOrEmpty() || amount.IsNullOrEmpty())
            {
                MessageBox.Show("Fill all inputs");
                return;
            }

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://measurement-unit-converter.p.rapidapi.com/length?value={amount}&from={fromUnit}&to={toUnit}"),
                Headers =
                {
                    { "x-rapidapi-key", "e038cee021msh9bb6e855b6f66dbp1ffd84jsn311270b306ce" },
                    { "x-rapidapi-host", "measurement-unit-converter.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var jsonObject = JObject.Parse(body);

                var result = jsonObject["result"].Value<string>();

                textBoxResult.Text = result;
                clearInputs();
                MessageBox.Show(result);
            }
        }

        // Convertor of Temperature Units
        public void temperatureConvertor()
        {
            string fromUnit = textBoxFrom.Text.ToString().Trim();
            string toUnit = textBoxTo.Text.ToString().Trim();
            string amount = textBoxAmount.Text.ToString().Trim();

            if (fromUnit.IsNullOrEmpty() || toUnit.IsNullOrEmpty() || amount.IsNullOrEmpty())
            {
                MessageBox.Show("Fill all inputs");
                return;
            }

            /*
            
            list.Add(new Unit("Celsius", "°C"));
            list.Add(new Unit("Fahrenheit", "°F"));
            list.Add(new Unit("Kelvin", "K"));
            list.Add(new Unit("Rankine", "°R"));
            
             */

            decimal result = 0.0M;
            if (fromUnit.Equals("°C") && toUnit.Equals("°F"))
                result = TemperatureConvertor.CelsiusToFahrenheit(Decimal.Parse(amount));
            else if (fromUnit.Equals("°C") && toUnit.Equals("K"))
                result = TemperatureConvertor.CelsiusToKelvin(Decimal.Parse(amount));
            else if (fromUnit.Equals("°C") && toUnit.Equals("°R"))
                result = TemperatureConvertor.CelsiusToRankine(Decimal.Parse(amount));

            else if (fromUnit.Equals("°F") && toUnit.Equals("°C"))
                result = TemperatureConvertor.FahrenheitToCelsius(Decimal.Parse(amount));
            else if (fromUnit.Equals("°F") && toUnit.Equals("K"))
                result = TemperatureConvertor.FahrenheitToKelvin(Decimal.Parse(amount));
            else if (fromUnit.Equals("°F") && toUnit.Equals("°R"))
                result = TemperatureConvertor.FahrenheitToRankine(Decimal.Parse(amount));

            else if (fromUnit.Equals("K") && toUnit.Equals("°C"))
                result = TemperatureConvertor.KelvinToCelsius(Decimal.Parse(amount));
            else if (fromUnit.Equals("K") && toUnit.Equals("°F"))
                result = TemperatureConvertor.KelvinToFahrenheit(Decimal.Parse(amount));
            else if (fromUnit.Equals("K") && toUnit.Equals("°R"))
                result = TemperatureConvertor.KelvinToRankine(Decimal.Parse(amount));

            else if (fromUnit.Equals("°R") && toUnit.Equals("°C"))
                result = TemperatureConvertor.RankineToCelsius(Decimal.Parse(amount));
            else if (fromUnit.Equals("°R") && toUnit.Equals("°F"))
                result = TemperatureConvertor.RankineToFahrenheit(Decimal.Parse(amount));
            else if (fromUnit.Equals("°R") && toUnit.Equals("°K"))
                result = TemperatureConvertor.RankineToKelvin(Decimal.Parse(amount));

            textBoxResult.Text = result.ToString();
            clearInputs();
        }

        
        // Convertor of Mass Units
        public void massConvertor()
        {
            string fromUnit = textBoxFrom.Text.ToString().Trim();
            string toUnit = textBoxTo.Text.ToString().Trim();
            string amount = textBoxAmount.Text.ToString().Trim();

            if (fromUnit.IsNullOrEmpty() || toUnit.IsNullOrEmpty() || amount.IsNullOrEmpty())
            {
                MessageBox.Show("Fill all inputs");
                return;
            }

            /*
                list.Add(new Unit("Gram", "m"));
                list.Add(new Unit("Kilogram", "kg"));
                list.Add(new Unit("Pound", "lb"));
                list.Add(new Unit("Ounce", "oz"));
                list.Add(new Unit("Ton", "t"));
            */

            decimal result = 0.0M;

            if (fromUnit.Equals("g") && toUnit.Equals("kg"))
                result = MassConvertor.GramToKilograms(Decimal.Parse(amount));
            else if (fromUnit.Equals("g") && toUnit.Equals("lb"))
                result = MassConvertor.GramToPounds(Decimal.Parse(amount));
            else if (fromUnit.Equals("g") && toUnit.Equals("oz"))
                result = MassConvertor.GramToOunces(Decimal.Parse(amount));
            else if (fromUnit.Equals("g") && toUnit.Equals("t"))
                result = MassConvertor.GramToTons(Decimal.Parse(amount));

            else if (fromUnit.Equals("kg") && toUnit.Equals("g"))
                result = MassConvertor.KilogramToGrams(Decimal.Parse(amount));
            else if (fromUnit.Equals("kg") && toUnit.Equals("lb"))
                result = MassConvertor.KilogramToPounds(Decimal.Parse(amount));
            else if (fromUnit.Equals("kg") && toUnit.Equals("oz"))
                result = MassConvertor.KilogramToOunces(Decimal.Parse(amount));
            else if (fromUnit.Equals("kg") && toUnit.Equals("t"))
                result = MassConvertor.KilogramToTons(Decimal.Parse(amount));

            else if (fromUnit.Equals("lb") && toUnit.Equals("g"))
                result = MassConvertor.PoundToGrams(Decimal.Parse(amount));
            else if (fromUnit.Equals("lb") && toUnit.Equals("kg"))
                result = MassConvertor.PoundToKilograms(Decimal.Parse(amount));
            else if (fromUnit.Equals("lb") && toUnit.Equals("oz"))
                result = MassConvertor.PoundToOunces(Decimal.Parse(amount));
            else if (fromUnit.Equals("lb") && toUnit.Equals("t"))
                result = MassConvertor.PoundToTons(Decimal.Parse(amount));

            else if (fromUnit.Equals("oz") && toUnit.Equals("g"))
                result = MassConvertor.OunceToGrams(Decimal.Parse(amount));
            else if (fromUnit.Equals("oz") && toUnit.Equals("kg"))
                result = MassConvertor.OunceToKilograms(Decimal.Parse(amount));
            else if (fromUnit.Equals("oz") && toUnit.Equals("lb"))
                result = MassConvertor.OunceToPounds(Decimal.Parse(amount));
            else if (fromUnit.Equals("oz") && toUnit.Equals("t"))
                result = MassConvertor.OunceToTons(Decimal.Parse(amount));

            else if (fromUnit.Equals("t") && toUnit.Equals("g"))
                result = MassConvertor.TonToGrams(Decimal.Parse(amount));
            else if (fromUnit.Equals("t") && toUnit.Equals("kg"))
                result = MassConvertor.TonToKilograms(Decimal.Parse(amount));
            else if (fromUnit.Equals("t") && toUnit.Equals("lb"))
                result = MassConvertor.TonToPounds(Decimal.Parse(amount));
            else if (fromUnit.Equals("t") && toUnit.Equals("oz"))
                result = MassConvertor.TonToOunces(Decimal.Parse(amount));

            textBoxResult.Text = result.ToString();
            clearInputs();
        }












        private void clearInputs()
        {
            textBoxFrom.Clear();
            textBoxTo.Clear();
            textBoxAmount.Clear();
        }

    }
}
