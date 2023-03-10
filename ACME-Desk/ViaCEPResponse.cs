using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace ACME_Desk
{
    public class ViaCEPResponse
    {
        public ViaCEPResponse(
            string cep,
            string logradouro,
            string complemento,
            string bairro,
            string localidade,
            string uf,
            string ibge,
            string gia,
            string ddd,
            string siafi
            )
        {
            this.cep = cep;
            this.logradouro = logradouro;
            this.complemento = complemento;
            this.bairro = bairro;
            this.localidade = localidade;
            this.uf = uf;
            this.ibge = ibge;
            this.gia = gia;
            this.ddd = ddd;
            this.siafi = siafi;
        }

        public string cep { get; private set; }
        public string logradouro { get; private set; }
        public string complemento { get; private set; }
        public string bairro { get; private set; }
        public string localidade { get; private set; }
        public string uf { get; private set; }
        public string ibge { get; private set; }
        public string gia { get; private set; }
        public string ddd { get; private set; }
        public string siafi { get; private set; }

        public static ViaCEPResponse HandleGetAddress(string cep)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri($"http://viacep.com.br/ws/");

                    var response = client.GetAsync($"{cep}/json/").Result;
                    var data = response.Content.ReadAsStringAsync().Result;

                    if (!response.IsSuccessStatusCode) return null;

                    ViaCEPResponse APIResponse = JsonConvert.DeserializeObject<ViaCEPResponse>(data);
                    return APIResponse;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
