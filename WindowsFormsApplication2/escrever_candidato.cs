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
    public partial class escrever_candidato : Form
    {
        bool a = false;
        public escrever_candidato()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
      
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "Nome" && textBox1.Text!="") && (comboBox1.Text != "") && (textBox3.Text != "Idade" && textBox3.Text!="") && (textBox4.Text != "BI" && textBox4.Text!=""))
            {
                int v_idade = int.Parse(textBox3.Text);
                array.nomes.Add(textBox1.Text);
                array.curso.Add(comboBox1.Text);
                array.bi.Add(textBox4.Text);
                if (radioButton1.Checked)
                {
                    array.sexo.Add("Masculino");
                    a = true;
                    cl_estatistica.soma_masculino++;
                }
                else if (radioButton2.Checked)
                {
                    array.sexo.Add("Femenino");
                    a = true;
                    cl_estatistica.soma_femenino++;
                }


                if (v_idade >= 12 && v_idade <= 20)
                {
                    array.idades.Add(v_idade);
                    if (a == true)
                    {
                        array.contador++;
                        MessageBox.Show("o seu numero de candidato e = " +array.contador);
                        array.cont += 1;
                        
                        cl_estatistica.soma++;
                    }
                    else
                        MessageBox.Show("selecione o seu sexo");
                }
                else
                {
                    MessageBox.Show("a idade do candidato deve estar no intervalo entre 12 e 20");
                }

            }
            else
            {
                MessageBox.Show("preenha todos os formularios");
            }
             }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void escrever_candidato_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
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
    }
}
