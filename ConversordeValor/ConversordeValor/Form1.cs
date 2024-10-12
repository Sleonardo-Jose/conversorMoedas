using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversordeValor
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Variavel
            decimal resultado;
            //Verifica se os campos não estão vazios
            if(textBox1.Text != "" && textBox2.Text != "")
                {
                    resultado = Convert.ToDecimal(textBox1.Text)* Convert.ToDecimal(textBox2.Text);
                
                  textBox1.Text = resultado.ToString();
                // C = Converter o numero para moeda (Coin)
                }
            else 
            {
                MessageBox.Show("Digite Algo: ");            
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
