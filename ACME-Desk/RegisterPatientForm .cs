using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ACME_Desk
{
    public partial class RegisterPatientForm : Form
    {
        public RegisterPatientForm()
        {
            InitializeComponent();
        }

        private void mskRegisterCep_KeyUp(object sender, KeyEventArgs e)
        {
            if (mskRegisterCep.Text.Length != 8) return;
            Thread.Sleep(500);

            var addressData = ViaCEPResponse.HandleGetAddress(mskRegisterCep.Text);

            txbRegisterBairro.Text = addressData.bairro;
            txbRegisterRua.Text = addressData.logradouro;
            txbRegisterCidade.Text = addressData.localidade;
            txbRegisterEstado.Text = addressData.uf;
        }

        private void btnEditConfirmar_Click(object sender, System.EventArgs e)
        {
            if (
                dtRegisterNascimento.Text.Length == 0 ||
                dtRegisterNascimento.Text.Length == 0 ||
                mskRegisterCpf.Text.Length == 0 ||
                cbxRegisterGenero.Text.Length == 0 ||
                txbRegisterRua.Text.Length == 0 ||
                txbRegisterNumero.Text.Length == 0 ||
                txbRegisterBairro.Text.Length == 0 ||
                txbRegisterCidade.Text.Length == 0 ||
                txbRegisterEstado.Text.Length == 0 ||
                mskRegisterCep.Text.Length == 0
                )
            {
                MessageBox.Show("Preencha todos os dados", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            var botaoPressionado = MessageBox.Show("Confirma o cadastro deste paciente?", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (botaoPressionado == DialogResult.Cancel) return;

            try
            {
                var inputData =
                    new PatientData(
                            txbRegisterNome.Text,
                            dtRegisterNascimento.Text,
                            mskRegisterCpf.Text,
                            cbxRegisterGenero.Text,
                            txbRegisterRua.Text,
                            txbRegisterNumero.Text,
                            txbRegisterBairro.Text,
                            txbRegisterCidade.Text,
                            txbRegisterEstado.Text,
                            mskRegisterCep.Text
                        );

                var json = JsonConvert.SerializeObject(inputData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri($"http://localhost:5158/patients/");

                    var response = client.PostAsync("register", content).Result;
                    if (!response.IsSuccessStatusCode) return;

                    var responseMessage = response.Content.ReadAsStringAsync().Result;
                    MessageBox.Show($"{responseMessage}", $"{response.StatusCode}", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Dispose();
                    var newPatientsList = Patients.GetList();
                    PatientsForm.dataGridView1.DataSource = newPatientsList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Erro!");
            }
        }
        private void RegisterPatientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btnEditCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void mskRegisterCpf_Click(object sender, EventArgs e)
        {
            mskRegisterCpf.SelectionStart = 0;
        }

        private void mskRegisterCep_Click(object sender, EventArgs e)
        {
            mskRegisterCep.SelectionStart = 0;
        }
    }
}
