using Aqua.EnumerableExtensions;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
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
            setUpImagesAndIcons();
        }

        private void buttonCurrencies_Click(object sender, EventArgs e)
        {
            FormCurrencies formCurrencies = new FormCurrencies();
            formCurrencies.ShowDialog();
        }

        private void buttonUnits_Click(object sender, EventArgs e)
        {
            FormUnits formUnits = new FormUnits();
            formUnits.ShowDialog();
        }

        private void buttonUnits_MouseHover(object sender, EventArgs e)
        {
            buttonUnits.BackColor = Color.Teal;
        }

        private void setUpImagesAndIcons()
        {
            this.Icon = new Icon(@"..\..\Images\ic_logo_currency.ico");
            this.pictureBoxLogo.Image = Image.FromFile(@"..\..\Images\ic_logo_currency.png");
            this.pictureBox1.Image = Image.FromFile(@"..\..\Images\ic_correct.png");
            this.pictureBox2.Image = Image.FromFile(@"..\..\Images\ic_correct.png");
            this.pictureBox3.Image = Image.FromFile(@"..\..\Images\ic_correct.png");
        }
    }
}
