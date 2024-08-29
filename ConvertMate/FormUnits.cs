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

        public FormUnits()
        {
            InitializeComponent();
            setUpUnitGroups();
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
            list.Add(new Unit("Reaumur", "°Re"));
            unitGroupTemperature = new UnitGroup(list);

            list = new List<Unit>();
            list.Add(new Unit("Gram", "m"));
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
            listBoxMeasurments.Items.Clear();
            foreach(Unit unit in unitGroupDistance.unitsList)
            {
                listBoxMeasurments.Items.Add(unit);
            }
        }

        private void buttonTemperature_Click(object sender, EventArgs e)
        {
            listBoxMeasurments.Items.Clear();
            foreach (Unit unit in unitGroupTemperature.unitsList)
            {
                listBoxMeasurments.Items.Add(unit);
            }
        }

        private void buttonMass_Click(object sender, EventArgs e)
        {
            listBoxMeasurments.Items.Clear();
            foreach (Unit unit in unitGroupMass.unitsList)
            {
                listBoxMeasurments.Items.Add(unit);
            }
        }

        private void buttonVolume_Click(object sender, EventArgs e)
        {
            listBoxMeasurments.Items.Clear();
            foreach (Unit unit in unitGroupVolume.unitsList)
            {
                listBoxMeasurments.Items.Add(unit);
            }
        }

        private void buttonTime_Click(object sender, EventArgs e)
        {
            listBoxMeasurments.Items.Clear();
            foreach (Unit unit in unitGroupTime.unitsList)
            {
                listBoxMeasurments.Items.Add(unit);
            }
        }

        private void listBoxMeasurments_DoubleClick(object sender, EventArgs e)
        {
            if (counter == 1)
            {
                string unit = listBoxMeasurments.SelectedItem.ToString();
                textBoxFrom.Text = unit;
                counter++;
            }
            else
            {
                string unit = listBoxMeasurments.SelectedItem.ToString();
                textBoxTo.Text = unit;
                counter = 1;
            }
        }
    }
}
