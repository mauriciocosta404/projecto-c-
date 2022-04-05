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
    public partial class eliminar_candidato : Form
    {
        public eliminar_candidato()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                int num = array.contador;
                int a = int.Parse(textBox1.Text);
                if (a > 0 && a <= num) {
                    if (array.nomes[a - 1] == "(eliminado)")
                    {
                        MessageBox.Show("este candidato já foi eliminado");
                    }
                    else if (array.nomes[a - 1] != "(eliminado)")
                    {
                        if (MessageBox.Show("pretendes eliminar este candidato?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            label3.Text = array.nomes[a - 1].ToString() + " foi eliminado com sucesso";
                            array.nomes[a - 1] = "(eliminado)";
                            array.curso[a - 1] = "(eliminado)";
                            if (array.sexo[a - 1] == "Masculino")
                            {
                                cl_estatistica.soma_masculino--;
                            }
                            else if (array.sexo[a - 1] == "Femenino")
                            {
                                cl_estatistica.soma_femenino--;
                            }
                            cl_estatistica.soma--;
                            array.sexo[a - 1] = "(eliminado)";
                            array.idades[a - 1] = "(eliminado)";
                            array.bi[a - 1] = "(eliminado)";
                            array.cont--;
                        }
                    }
                }
                else
                    MessageBox.Show("este candidato nao existe");
            }
            catch
            {
                MessageBox.Show("digite o seu numero de inscricao");
            }
        }

        private void eliminar_candidato_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
