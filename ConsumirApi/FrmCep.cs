using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace ConsumirApi
{
    public partial class    FrmCep : Form
    {
        public FrmCep()
        {
            InitializeComponent();
        }

        private void MetodoBuscarCep()
        {
            int Ceps;
            if (!int.TryParse(txtBuscarCep.Text, out Ceps))
            {
                MessageBox.Show("Digite um CEP valido");
                txtBuscarCep.Focus();
                txtBuscarCep.Clear();
                return;
            }

            HttpClient httpclient = new HttpClient();
            string url = $"https://brasilapi.com.br/api/cep/v1/{Ceps}";

            var response = httpclient.GetAsync(url).Result;
            
            if (!response.IsSuccessStatusCode.Equals(true))
            {
                MessageBox.Show("Erro ao carregar o dado digitado");
                return;
            }
            
            var json = response.Content.ReadAsStringAsync().Result;

            var ceps = JsonConvert.DeserializeObject<Cep>(json);


            dgvCep.DataSource = new List<Cep> { ceps };
        }

        private void btnBuscarCep_Click(object sender, EventArgs e)
        {
            MetodoBuscarCep();
        }

        private void dgvCep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
