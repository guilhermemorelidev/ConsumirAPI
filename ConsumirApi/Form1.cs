using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace ConsumirApi
{
    public partial class FrmApi : Form
    {
        public FrmApi()
        {
            InitializeComponent();
        }

        private void MetodoBuscarFeriado()
        {
            int ano;

            if (!int.TryParse(txtBuscarApi.Text, out ano))
            {
                MessageBox.Show("Digite um ano valido");
                txtBuscarApi.Focus();
                txtBuscarApi.Clear();
                return;
            }

            HttpClient httpClient = new HttpClient();
            string url = $"https://brasilapi.com.br/api/feriados/v1/{ano}";

            var response = httpClient.GetAsync(url).Result;

            if (!response.IsSuccessStatusCode.Equals(true))
            {
                MessageBox.Show("nao foi possivel buscar esse ano");
                return;
            }
            var json = response.Content.ReadAsStringAsync().Result;

            List<feriado> listaFeriados = JsonConvert.DeserializeObject<List<feriado>>(json) ?? new List<feriado>();

            dgvFeriados.DataSource = listaFeriados;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MetodoBuscarFeriado();
        }

        private void dgvFeriados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscarApi_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
