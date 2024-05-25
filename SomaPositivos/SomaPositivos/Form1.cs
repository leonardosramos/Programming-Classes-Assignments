using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomaPositivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soma = 0;
            string[] numeros = textBox1.Text.Split(',');

            for (int i = 0; i < numeros.Length; i++)
            {
                if (int.TryParse(numeros[i].Trim(), out int num))
                {
                    if (num >= 0)
                    {
                        soma += num;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    // Tratamento para números inválidos
                    MessageBox.Show("Por favor, insira apenas números inteiros positivos ou negativos válidos.");
                    label2.Text = "";
                    return;
                }
            }

            label2.Text = soma.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
