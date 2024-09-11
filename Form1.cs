using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversor_Moeda
{
    public partial class Form1 : Form
    {

        private static readonly HttpClient client = new HttpClient(); //Para o uso da API
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCoverter_Click(object sender, EventArgs e)
        {
            if (textValorMoeda.Text.Equals(String.Empty))
            {
                MessageBox.Show("Por favor coloque um valor para converter");
            } else
            {
                converterMoedaFormaApi();
            }
        }

        private async void converterMoedaFormaApi()
        {
            try
            {
                string moedaOrigem = comboMoedaOrigem.SelectedItem.ToString();
                string moedaDestino = comboMoedaDestino.SelectedItem.ToString();

                if(moedaDestino.Equals(String.Empty) || moedaOrigem.Equals(String.Empty))
                {
                    MessageBox.Show("Porfavor selecione uma das opções disponíveis");
                } else
                {
                    decimal valorInserido = Convert.ToDecimal(textValorMoeda.Text);

                    decimal taxaCambio = await pegarTaxaCambio(moedaOrigem, moedaDestino);

                    decimal conversao = valorInserido * taxaCambio;

                    String resultado = $"{conversao:f2}";
                    atualizarResultado(resultado);
                }
                
            }
            catch (Exception ex)
            {
            }
        }

        private async Task<decimal> pegarTaxaCambio(string moedaOrigem, string moedaDestino)
        {
            
            string apiKey = "3f507a66ee043bde4a781ba5"; //Chave da API para poder efetuar a conversão
            string apiUrl = $"https://v6.exchangerate-api.com/v6/{apiKey}/pair/{moedaOrigem}/{moedaDestino}";

            HttpResponseMessage responseMessage = await client.GetAsync(apiUrl);
            responseMessage.EnsureSuccessStatusCode(); //Fazer que seja executada com sucesso

           string responseBody = await responseMessage.Content.ReadAsStringAsync();

            //Parse do JSON 
            JObject data = JObject.Parse(responseBody);

            decimal taxaCambio = (decimal)data["conversion_rate"];
            return taxaCambio;
        }

       

        private void atualizarResultado(String texto)
        {
            tipoMoedaResultado.Text = comboMoedaDestino.SelectedItem.ToString();
            resultadoConvercao.Text = texto;
            tipoMoedaResultado.Visible = true;
            resultadoConvercao.Visible = true;

            int posicaoX = tipoMoedaResultado.Location.X + tipoMoedaResultado.Width;

            resultadoConvercao.Location = new Point(posicaoX, resultadoConvercao.Location.Y);
        }

        private void comboMoedaOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tipoMoedaResultado.Visible = false;
            resultadoConvercao.Visible = false;
            textValorMoeda.Text = String.Empty;
            comboMoedaDestino.SelectedIndex = -1;
            comboMoedaOrigem.SelectedIndex = -1;
        }
    }
}
