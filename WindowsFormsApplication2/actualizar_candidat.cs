using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class actualizar_candidat : Form
    {
        public actualizar_candidat()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

    
            int num = array.contador;
            try {
            int a = int.Parse(textBox1.Text);
           
            if (a > 0 && a <= num)
            {
                if ((textBox4.Text != "Nome" && textBox4.Text!="") && (textBox3.Text != "Idade"&& textBox3.Text!="" )&& comboBox1.Text!="")
                {
                    if (array.nomes[a - 1] == "(eliminado)")
                    {
                        MessageBox.Show("este candidato já foi eliminado");
                    }
                    else
                    {
                            int idade =int.Parse(textBox3.Text);
                            if (idade >= 12 && idade <= 20)
                            {
                                array.nomes[a - 1] = textBox4.Text;
                                array.curso[a - 1] = comboBox1.Text;

                                array.idades[a - 1] = textBox3.Text;
                                MessageBox.Show("candidato actualizado");
                            }
                            else
                                MessageBox.Show("a sua idade deve estar no intervalo entre 12 e 20");
                    }
                }
                else
                    MessageBox.Show("preencha todos os formularios");
            }
            else
                MessageBox.Show("este candidato não existe");
            }
            catch (Exception error)
            {
                MessageBox.Show("digite o numero de candidato");
            }
        }

        private void actualizar_candidat_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
