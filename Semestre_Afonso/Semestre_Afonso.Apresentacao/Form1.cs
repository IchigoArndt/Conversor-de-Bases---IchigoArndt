﻿using Infragistics.Win;
using Infragistics.Win.UltraMessageBox;
using Semestre_Afonso.Aplicacao;
using Semestre_Afonso.Apresentacao.Util;
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
            txtBase_O.Enabled = false;
            txt_BaseN.Enabled = false;

        }

        private void carregaLista()
        {
            cmb_conversao.Items.Add("Decimal para Binário");
            cmb_conversao.Items.Add("Binario para Decimal");
            cmb_conversao.Items.Add("Decimal para Octal");
            cmb_conversao.Items.Add("Decimal para Hexadecimal");
            //Conversões de Texto
            cmb_conversao.Items.Add("Texto para Binario");
            cmb_conversao.Items.Add("Texto para Octal");
            cmb_conversao.Items.Add("Texto para Hexadecimal");
            cmb_conversao.Items.Add("Texto para Decimal");
        }

        private void carregaBarra(string result)
        {
            int porcetagem = 100 / result.Length;

            progressoConversao.Step = porcetagem;

            progressoConversao.Value = 0;
            #region Aparencia
            progressoConversao.UseOsThemes = DefaultableBoolean.False;

            progressoConversao.Appearance.BackColor = Color.Black;

            progressoConversao.FillAppearance.BackColor = Color.Red;

            progressoConversao.FillAppearance.ForeColor = Color.Black;
            #endregion
            for (int i = 0; i <= result.Length; i++)
            {
                progressoConversao.PerformStep();
                progressoConversao.Update();
                Thread.Sleep(2);
            }
            if (progressoConversao.Step != 100)
            {
                progressoConversao.Step = 100;
            }
            MessageBox.Show("Conversão Realizada ");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmb_conversao_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBase_O.Enabled = true;
            txt_BaseN.Enabled = true;
        }
       
        private void txt_BaseO_Leave(object sender, EventArgs e)
        {
            ultraButton1_Click(sender,e);
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            Servico sv = new Servico();
            Validacao validacao = new Validacao();

            int baseConversaoSelecionada = sv.BaseNumerica(cmb_conversao.SelectedItem.ToString());
            string numeroConversao = txtBase_O.Text;
            if (validacao.Validacaos(numeroConversao.ToList()) || baseConversaoSelecionada >= -3 && baseConversaoSelecionada <= 0)
            {
                string resultado = string.Empty;
                if (baseConversaoSelecionada == 2 || baseConversaoSelecionada == 8 || baseConversaoSelecionada == 16)
                {
                    resultado = sv.organizaConversao(baseConversaoSelecionada, null, numeroConversao);
                }
                else
                {
                    switch (baseConversaoSelecionada)
                    {
                        case 4:
                            {
                                resultado = sv.organizaConversao(baseConversaoSelecionada, sv.ConversaoLista(numeroConversao), null);
                                break;
                            }
                        case 0:
                            {
                                resultado = sv.organizaConversao(baseConversaoSelecionada, null, numeroConversao);
                                break;
                            }
                        case -1:
                            {
                                resultado = sv.organizaConversao(baseConversaoSelecionada, null, numeroConversao);
                                break;
                            }
                        case -2:
                            {
                                resultado = sv.organizaConversao(baseConversaoSelecionada, null, numeroConversao);
                                break;
                            }
                        case -3:
                            {
                                resultado = sv.organizaConversao(baseConversaoSelecionada, null, numeroConversao);
                                break;
                            }
                    }
                }
                carregaBarra(resultado);
                txt_BaseN.Text = resultado;
            }
            else
            {
                string mensagemErro = "Valor do campo inválido!" + "<br/>" + "Por favor digite somente numeros" + "<br/>" + "Ou escolha a conversão de texto";
                mostrarMensagemAlerta(cssBotoes.cssBotaoErro(mensagemErro));
                txtBase_O.Text = string.Empty;
            }
        }

        private void mostrarMensagemAlerta(UltraMessageBoxInfo definicao)
        {
            #region Css do botão de alerta 
            UltraMessageBoxManager executorMensagem = new UltraMessageBoxManager();
            executorMensagem.ButtonAlignment = HAlign.Center;
            executorMensagem.ShowMessageBox(definicao);
            #endregion
        }

        private void progressoConversao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ultraCalculator1_AfterCalculationComplete(object sender, EventArgs e)
        {

        }
    }
}
