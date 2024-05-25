using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumPar1aN
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

            for (int i = 0; i <= valor; i++)
            {
                if (i % 2 == 0)
                {
                    label2.Text += i.ToString() + " ";
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
