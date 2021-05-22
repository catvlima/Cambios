using Cambios.Modelos;
using Newtonsoft.Json;
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


namespace Cambios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadRates();
        }

        private async void LoadRates()
        {
            //bool load;

            var client = new HttpClient();
            client.BaseAddress = new Uri("http://cambios.somee.com");

            var response = await client.GetAsync("/api/rates");

            var result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.ReasonPhrase);
                return;
            }

            var rates = JsonConvert.DeserializeObject<List<Rate>>(result);

            comboBoxOrigem.DataSource = rates;

        }
    }
}
