using Semestre_Afonso.Aplicacao;
using Semestre_Afonso.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semestre_Afonso.Apresentacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            carregaLista();
            txt_BaseO.Enabled = false;
            txt_BaseN.Enabled = false;

        }

        private void carregaLista()
        {
            cmb_conversao.Items.Add("Decimal para Binário");
            cmb_conversao.Items.Add("Decimal para Octal");
            cmb_conversao.Items.Add("Decimal para Hexadecimal");
            cmb_conversao.Items.Add("Texto para Binario");
            cmb_conversao.Items.Add("Binario para Decimal");
        }

        private void carregaBarra(string result)
        {
            int porcetagem = 100 / result.Length;

            pb.Step = porcetagem;

            pb.Value = 0;

            for (int i = 0; i < result.Length; i++)
            {
                pb.PerformStep();
                pb.Update();
                Thread.Sleep(2);
            }

            MessageBox.Show("Conversão Realizada ");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmb_conversao_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_BaseO.Enabled = true;
        }

        private void btn_conversao_Click(object sender, EventArgs e)
        {
            Servico sv = new Servico();

            if (true)
            {
                int baseConversaoSelecionada = sv.BaseNumerica(cmb_conversao.SelectedItem.ToString());
                string numeroConversao = txt_BaseO.Text;
                string resultado = string.Empty;
                if(baseConversaoSelecionada == 2 || baseConversaoSelecionada == 8 || baseConversaoSelecionada == 16)
                {
                    resultado = sv.organizaConversao(baseConversaoSelecionada, null, numeroConversao);
                }
                else
                {
                    switch (baseConversaoSelecionada)
                    {
                      case 4:
                         {
                                resultado = sv.organizaConversao(baseConversaoSelecionada,sv.ConversaoLista(numeroConversao),null);
                                break;
                         }
                    }
                }
                carregaBarra(resultado);
                txt_BaseN.Text = resultado;
            }
            else
            {
                txt_BaseO.Text = "";
                MessageBox.Show("Por favor Verifique o tamanho do numero informado \n Verfique se foi usado apenas letras");
            }  
        }

    }
}
