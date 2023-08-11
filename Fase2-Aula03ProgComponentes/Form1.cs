using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase2_Aula03ProgComponentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome;
            nome = textBox1.Text;
            MessageBox.Show($"Seja bem-vindo {nome}");
            nome = label2.Text = ($"Seu nome é {nome}");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }
    }
}
