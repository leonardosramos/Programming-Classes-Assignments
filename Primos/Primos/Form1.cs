using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            string[] intervalo = textBox1.Text.Split(',');

            if (intervalo.Length == 2 && int.TryParse(intervalo[0], out int inicio) && int.TryParse(intervalo[1], out int fim))
            {
                for (int num = Math.Max(inicio, 2); num <= fim; num++)
                {
                    bool ehPrimo = true;
                    for (int i = 2; i * i <= num; i++)
                    {
                        if (num % i == 0)
                        {
                            ehPrimo = false;
                            break;
                        }
                    }

                    if (ehPrimo)
                    {
                        label2.Text += num + ", ";
                    }
                }

                if (!string.IsNullOrEmpty(label2.Text))
                {
                    label2.Text = label2.Text.TrimEnd(',', ' ');
                }
                else
                {
                    label2.Text = "Não há números primos no intervalo especificado.";
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira dois números inteiros separados por vírgula.");
            }
        }
    }
}
