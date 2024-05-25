using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumNa0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Resultado: ";
            int valor = int.Parse(textBox1.Text);

            for (int i = valor; i >= 0; i--)
            {
                label2.Text += i.ToString() + " ";
            }

        }
    }
}
