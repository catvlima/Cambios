using Cambios.Modelos;
using Cambios.Servicos;
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
        private NetworkService networkService;

        private ApiService apiService;

        public List<Rate> Rates { get; set; } = new List<Rate>();

        public Form1()
        {
            InitializeComponent();
            networkService = new NetworkService();
            apiService = new ApiService();
            LoadRates();
        }

        private async void LoadRates()
        {
            //bool load;

            lbl_Resultado.Text = "A atualizar taxas...";

            var connection = networkService.CheckConnection();

            if (!connection.IsSuccess)
            {
                MessageBox.Show(connection.Message);
                return;
            }
            else
            {
                await LoadApiRates();
            }

            comboBoxOrigem.DataSource = Rates;
            comboBoxOrigem.DisplayMember = "Name";

            //Corrige bug da microsoft
            comboBoxDestino.BindingContext = new BindingContext();

            comboBoxDestino.DataSource = Rates;
            comboBoxDestino.DisplayMember = "Name";

            progressBar1.Value = 100;

            lbl_Resultado.Text = "Taxas carregadas";


        }

        private async Task LoadApiRates()
        {
            progressBar1.Value = 0;

            var response = await apiService.GetRates("http://cambios.somee.com", "/api/rates");

            Rates = (List<Rate>) response.Result;
           
        }
    }
}
