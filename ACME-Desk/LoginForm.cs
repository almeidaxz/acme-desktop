using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace ACME_Desk
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            tbxUsuario.Text = @"lucasbraz@email.com";
            mskSenha.Text = "12345678";
        }

        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.IndianRed;
            btnFechar.ForeColor = Color.White;
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            btnFechar.BackColor = DefaultBackColor;
            btnFechar.ForeColor = DefaultForeColor;
        }

        private void btnEntrar_MouseEnter(object sender, EventArgs e)
        {
            btnEntrar.ForeColor = Color.White;
            btnEntrar.BackColor = Color.CornflowerBlue;
        }

        private void btnEntrar_MouseLeave(object sender, EventArgs e)
        {
            btnEntrar.ForeColor = DefaultForeColor;
            btnEntrar.BackColor = DefaultBackColor;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var inputData = new Login(tbxUsuario.Text, mskSenha.Text);
            var json = JsonConvert.SerializeObject(inputData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri($"http://localhost:5158/");

                var response = client.PostAsync($"user/login", content).Result;

                if (response.IsSuccessStatusCode)
                {
                    Form home = new PatientsForm();
                    home.Show();
                    this.Visible = false;
                }
                else
                {
                    var responseContent = response.Content.ReadAsStringAsync().Result;
                    MessageBox.Show(responseContent, "Fracasso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
