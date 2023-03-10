using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace ACME_Desk
{
    public partial class PatientsForm : Form
    {
        public PatientsForm()
        {
            InitializeComponent();
        }

        private void PatientsGrid_Load(object sender, EventArgs e)
        {
            var patientsList = Patients.GetList();
            dataGridView1.DataSource = patientsList;
        }

        private void PatientsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            handleOpenEdit();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Form login = new LoginForm();
            login.Show();
            this.Dispose();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Form registerForm = new RegisterPatientForm();
            registerForm.Show();
        }

        internal void handleOpenEdit()
        {
            Patients paciente =
                new Patients(
                    (int)dataGridView1.SelectedRows[0].Cells["Id"].Value,
                    dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString(),
                    dataGridView1.SelectedRows[0].Cells["BirthDate"].Value.ToString(),
                    dataGridView1.SelectedRows[0].Cells["Cpf"].Value.ToString(),
                    dataGridView1.SelectedRows[0].Cells["Gender"].Value.ToString(),
                    dataGridView1.SelectedRows[0].Cells["AddressLine"].Value.ToString(),
                    dataGridView1.SelectedRows[0].Cells["AddresNumber"].Value.ToString(),
                    dataGridView1.SelectedRows[0].Cells["District"].Value.ToString(),
                    dataGridView1.SelectedRows[0].Cells["City"].Value.ToString(),
                    dataGridView1.SelectedRows[0].Cells["State"].Value.ToString(),
                    dataGridView1.SelectedRows[0].Cells["ZipCode"].Value.ToString(),
                    (bool)dataGridView1.SelectedRows[0].Cells["Active"].Value
            );

            Form editForm = new EditPatientForm(paciente);
            editForm.Show();
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            bool pacienteAtivo = (bool)dataGridView1.SelectedRows[0].Cells["Active"].Value.Equals(true);
            int pacienteId = (int)dataGridView1.SelectedRows[0].Cells["Id"].Value;

            try
            {
                if (pacienteAtivo)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        client.BaseAddress = new Uri($"http://localhost:5158/patients/");

                        var response = client.DeleteAsync($"{pacienteId}/delete").Result;
                        if (!response.IsSuccessStatusCode) return;

                        var responseMessage = response.Content.ReadAsStringAsync().Result;
                        MessageBox.Show($"{responseMessage}", $"{response.StatusCode}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    using (HttpClient client = new HttpClient())
                    {
                        client.BaseAddress = new Uri($"http://localhost:5158/patients/");
                        var emptyContent = new StringContent("", Encoding.UTF8, "application/json");

                        var response = client.PutAsync($"{pacienteId}/reactivate", emptyContent).Result;
                        if (!response.IsSuccessStatusCode) return;

                        var responseMessage = response.Content.ReadAsStringAsync().Result;
                        MessageBox.Show($"{responseMessage}", $"{response.StatusCode}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                var newPatientsList = Patients.GetList();
                PatientsForm.dataGridView1.DataSource = newPatientsList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
