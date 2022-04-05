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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                bool a = false, b = false;
                int v_idade;
                double v_salario;
                if (((textBox1.Text != "") && (textBox1.Text != "Nome")) && ((textBox2.Text != "") && (textBox2.Text != "Telefone")) &&
                    ((textBox3.Text != "") && (textBox3.Text != "Idade")) && ((textBox4.Text != "") && (textBox4.Text != "Salario")))
                {
                    v_idade = int.Parse(textBox3.Text);
                    v_salario = double.Parse(textBox4.Text);
                    dados_do_funcionario.nomes = textBox1.Text;
                    dados_do_funcionario.telefone = int.Parse(textBox2.Text);
                    if (v_idade >= 18 && v_idade <= 50) {
                        a = true;
                        dados_do_funcionario.idade = v_idade;
                    }
                    else
                    {
                        MessageBox.Show("a sua idade deve estar no intervalo entre 18 e 50");
                    }

                    if (v_salario >= 5000 && v_salario <= 10000)
                    {

                        b = true;
                        dados_do_funcionario.salario = v_salario;
                    }
                    else
                    {
                        MessageBox.Show("o seu salario deve estar no intervalo entre 5000 e 10000");
                    }
                }
                else
                {
                    MessageBox.Show("preenha todos os formularios");
                }
                if (a == true && b == true)
                {
                    MessageBox.Show("cadastro feito com sucesso");
                    if (MessageBox.Show("pretendes ver os seus dados", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        mostrar_no_funcionario m = new mostrar_no_funcionario();
                        m.ShowDialog();
                    }
                    else
                    {
                        menu_principal menu = new menu_principal();
                        menu.ShowDialog();
                    }
                }
            }
            catch
            {
                MessageBox.Show("verifique devidamente os seus dados");
            }
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text="";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }
    }
}
