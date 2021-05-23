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
        private List<Rate> Rates;

        private NetworkService networkService;

        private ApiService apiService;

        private DialogService dialogService;

        

        public Form1()
        {
            InitializeComponent();
            networkService = new NetworkService();
            apiService = new ApiService();
            dialogService = new DialogService();
            LoadRates();
        }

        private async void LoadRates()
        {
            bool load;

            lbl_Resultado.Text = "A atualizar taxas...";

            var connection = networkService.CheckConnection();

            if (!connection.IsSuccess)
            {
                LoadLocalRates();
                load = false;
                
            }
            else
            {
                await LoadApiRates();
                load = true;
            }

            if (Rates.Count == 0)
            {
                lbl_Resultado.Text = "Não há ligação à Internet" + Environment.NewLine +
                    "e não foram préviamente carregadas as taxas." + Environment.NewLine +
                    "Tente mais tarde!";

                return;
            }

            comboBoxOrigem.DataSource = Rates;
            comboBoxOrigem.DisplayMember = "Name";

            //Corrige bug da microsoft
            comboBoxDestino.BindingContext = new BindingContext();

            comboBoxDestino.DataSource = Rates;
            comboBoxDestino.DisplayMember = "Name";


            bt_Converter.Enabled = true;

            lbl_Resultado.Text = "Taxas atualizadas";

            if (load)
            {
                lbl_Status.Text = string.Format("Taxas carregadas da Internet em {0:F}", DateTime.Now);
            }
            else
            {
                lbl_Status.Text = string.Format("Taxas carregadas da base de dados.");
            }

            progressBar1.Value = 100;

            bt_Converter.Enabled = true;
            bt_Troca.Enabled = true;

        }

        private void LoadLocalRates()
        {
            MessageBox.Show("Não está implementado");
        }

        private async Task LoadApiRates()
        {
            progressBar1.Value = 0;

            var response = await apiService.GetRates("http://cambios.somee.com", "/api/rates");

            Rates = (List<Rate>) response.Result;
           
        }

        private void bt_Converter_Click(object sender, EventArgs e)
        {
            Converter();
        }

        private void Converter()
        {
            if (string.IsNullOrEmpty(txt_Valor.Text))
            {
                dialogService.ShowMessage("Erro", "Insira um valor a converter");
                return;
            }

            decimal valor;

            if (!decimal.TryParse(txt_Valor.Text, out valor))
            {
                dialogService.ShowMessage("Erro de conversão", "Valor terá de ser numérico");
                return;
            }

            if (comboBoxOrigem.SelectedItem == null)
            {
                dialogService.ShowMessage("Erro", "Tem de escolher uma moeda a converter");
                return;
            }

            if (comboBoxDestino.SelectedItem == null)
            {
                dialogService.ShowMessage("Erro", "Tem de escolher uma moeda de destino para converter");
                return;
            }

            var taxaOrigem = (Rate)comboBoxOrigem.SelectedItem;

            var taxaDestino = (Rate)comboBoxDestino.SelectedItem;

            var ValorConvertido = valor / (decimal)taxaOrigem.TaxRate * (decimal)taxaDestino.TaxRate;

            lbl_Resultado.Text = string.Format("{0} {1:C2} = {2} {3:C2}", taxaOrigem.Code, valor, taxaDestino.Code, ValorConvertido);
        }

        private void Troca()
        {
            var aux = comboBoxOrigem.SelectedItem;
            comboBoxOrigem.SelectedItem = comboBoxDestino.SelectedItem;
            comboBoxDestino.SelectedItem = aux;
            Converter();
        }

        

        private void bt_Troca_Click_1(object sender, EventArgs e)
        {
            Troca();
        }
    }
}
