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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(textBox1.Text);
            int baseNumerica = Convert.ToInt32(textBox3.Text);

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
    }
}
