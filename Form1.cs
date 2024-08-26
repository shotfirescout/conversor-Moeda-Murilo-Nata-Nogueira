using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversor_Moeda
{
    public partial class Form1 : Form
    {
        Dictionary<string, double> taxaCambio = new Dictionary<string, double>()
        {
            {"USD_TO_EUR", 0.89}, //Dolar para euro
            {"USD_TO_BRL", 5.25}, //Dolar para real
            {"BRL_TO_EUR", 0.16}, //Real para euro
            {"BRL_TO_USD", 1/5.25 }, //Real para Dolar
            {"EUR_TO_USD", 1/0.89 }, //Euro para Dolar
            {"EUR_TO_BRL", 1/0.18 }, //Euro para Real
            {"EQUALS", 1} //Quando os dois valores selecionados são iguais (USD To USD, EUR to EUR e BRL to BRL)

        };
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
                converterMoeda();
            }
        }

        private void converterMoeda()
        {
            //vai ler o valor inserido
            try
            {
                double valorInserido = Convert.ToDouble(textValorMoeda.Text);

                //pega os tipos selecionados
                string moedaOrigemSelecionada = comboMoedaOrigem.SelectedItem.ToString();
                string moedaDestinoSelecionada = comboMoedaDestino.SelectedItem.ToString();



                //Definindo a chave

                string chave = $"{moedaOrigemSelecionada}_TO_{moedaDestinoSelecionada}";
                if (moedaDestinoSelecionada == moedaOrigemSelecionada)
                {
                    chave = "EQUALS";
                }

                if(valorInserido < 0) //Verifica se o valor inserido é menor que zero ( se for vai executar o message box)
                {
                    MessageBox.Show("Porfavor coloque um valor que seja maior que zero");
                }
                else //Caso o contrario, ele vai executar a parte da chave
                {
                    if (taxaCambio.ContainsKey(chave))
                    {
                        double taxa = taxaCambio[chave];
                        double convercao = valorInserido * taxa;

                        String resultado = convercao.ToString("F2");

                        atualizarResultado(resultado);

                    }
                    else
                    {
                        MessageBox.Show("Porfavor selecione os itens que estão vazios");
                    }
                }
            }

               
            catch (FormatException exception)
            {
                MessageBox.Show("Formato Inválido para fazer a converção");
            }


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
