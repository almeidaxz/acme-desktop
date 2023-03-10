using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ACME_Desk
{
    public partial class EditPatientForm : Form
    {
        int pacienteId;
        public EditPatientForm(Patients paciente)
        {
            InitializeComponent();
            pacienteId = paciente.Id;
            txbEditNome.Text = paciente.Name;
            mskEditCpf.Text = paciente.Cpf;
            cbxEditGenero.Text = paciente.Gender;
            dtEditNascimento.Text = paciente.BirthDate;
            mskEditCep.Text = paciente.ZipCode;
            txbEditRua.Text = paciente.AddressLine;
            txbEditNumero.Text = paciente.AddresNumber;
            txbEditBairro.Text = paciente.District;
            txbEditCidade.Text = paciente.City;
            txbEditEstado.Text = paciente.State;
        }

        private void btnEditCancelar_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void btnEditConfirmar_Click(object sender, System.EventArgs e)
        {
            var botaoPressionado = MessageBox.Show("Confirma a edição dos dados do paciente?", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (botaoPressionado == DialogResult.Cancel) return;

            try
            {
                var inputData
                    = new PatientData(
                            txbEditNome.Text,
                            dtEditNascimento.Text,
                            mskEditCpf.Text,
                            cbxEditGenero.Text,
                            txbEditRua.Text,
                            txbEditNumero.Text,
                            txbEditBairro.Text,
                            txbEditCidade.Text,
                            txbEditEstado.Text,
                            mskEditCep.Text
                        );
                var json = JsonConvert.SerializeObject(inputData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri($"http://localhost:5158/patients/");

                    var response = client.PutAsync($"{pacienteId}/update", content).Result;
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

        private void mskEditCep_KeyUp(object sender, KeyEventArgs e)
        {
            if (mskEditCep.Text.Length != 8) return;
            Thread.Sleep(500);

            var addressData = ViaCEPResponse.HandleGetAddress(mskEditCep.Text);

            txbEditBairro.Text = addressData.bairro;
            txbEditRua.Text = addressData.logradouro;
            txbEditCidade.Text = addressData.localidade;
            txbEditEstado.Text = addressData.uf;
        }
    }
}
