using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(textBox1.Text);
            int soma = 0;
            label2.Text = "Resultado: ";

            for (int i = 0; i <= valor; i++)
            {
                soma += i;
            }
            label2.Text = "Resultado: " + soma.ToString();

        }
    }
}
