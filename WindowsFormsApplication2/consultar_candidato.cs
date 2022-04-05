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
    public partial class consultar_candidato : Form
    {
        public consultar_candidato()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = array.contador;
            int a = int.Parse(textBox1.Text);
            if (num >= 0)
            {
                if (a > 0 && a <= num)
                {
                    if (array.nomes[a-1] == "(eliminado)")
                    {
                        MessageBox.Show("este foi eliminado");
                    }
                    else {
                    label7.Text = array.nomes[a-1].ToString();
                    label8.Text = array.curso[a-1].ToString();
                    label9.Text = array.sexo[a-1].ToString();
                    label10.Text = array.bi[a-1].ToString();
                    label11.Text = array.idades[a-1].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("este candidato não existe");
                }
            }
            else
                MessageBox.Show("Este candidato não existe");
        }

        private void consultar_candidato_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
