using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeqFibonacci
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
            label2.Text = "Resultado: ";

            int a = 0, b = 1;

            for (int i = 0; a < valor; i++)
            {
                label2.Text += a.ToString() + " ";
                int temp = a + b;
                a = b;
                b = temp;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
