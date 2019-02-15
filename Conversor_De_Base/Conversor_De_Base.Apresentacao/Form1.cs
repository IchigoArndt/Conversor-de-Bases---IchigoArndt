using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_De_Base.Apresentacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            carregaList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(textBox1.Text);

            int baseNumerica = baseSelecionda(comboBox1.SelectedItem.ToString());

            Conversao bn = new Conversao();

            List<int> binario = new List<int>();

            binario = bn.conversao(numero,baseNumerica);

            string resultado = " ";

            foreach (var item in binario)
            {
                resultado += item;
            }

            textBox2.Text = resultado;

        }

        private int baseSelecionda(string baseTexto)
        {
            int baseSeleciona = 0;
            if(baseTexto.Equals("8"))
            {
                baseSeleciona =  Convert.ToInt32(baseTexto);
            }
            if (baseTexto.Equals("2"))
            {
                baseSeleciona = Convert.ToInt32(baseTexto);
            }
            return baseSeleciona;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void carregaList()
        {
            comboBox1.Items.Add("Decimal para Binário");
            comboBox1.Items.Add("Decimal para Octal");
        }
    }
}
