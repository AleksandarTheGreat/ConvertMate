using Aqua.EnumerableExtensions;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertMate
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCurrencies_Click(object sender, EventArgs e)
        {
            FormCurrencies formCurrencies = new FormCurrencies();
            formCurrencies.Show();
        }

        private void buttonUnits_Click(object sender, EventArgs e)
        {
            FormUnits formUnits = new FormUnits();
            formUnits.Show();
        }
    }
}
