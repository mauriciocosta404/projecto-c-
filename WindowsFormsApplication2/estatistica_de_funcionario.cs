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
    public partial class estatistica_de_funcionario : Form
    {
        public estatistica_de_funcionario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void estatistica_de_funcionarios_Load(object sender, EventArgs e)
        {
            string masculino;
            string femenino;
            if(cl_estatistica.soma_masculino>0 || cl_estatistica.soma_femenino>0) { 
                masculino = cl_estatistica.calcularmasculino().ToString();
                femenino = cl_estatistica.calcularfemenino().ToString();
                bunifuCircleProgressbar1.Value = int.Parse(masculino);
                bunifuCircleProgressbar2.Value = int.Parse(femenino);
                label2.Text = cl_estatistica.soma_masculino.ToString();
                label8.Text = cl_estatistica.soma_femenino.ToString();
              
                if (cl_estatistica.calcularmasculino() > cl_estatistica.calcularfemenino())
                {
                    if (cl_estatistica.calcularfemenino() < 20)
                    {
                        bunifuCircleProgressbar2.ProgressColor = Color.Red;
                        bunifuCircleProgressbar2.ForeColor = Color.Red;
                    }
                    else if (cl_estatistica.calcularfemenino() >= 20 && cl_estatistica.calcularfemenino()< 50)
                    {
                        bunifuCircleProgressbar2.ProgressColor = Color.OrangeRed;
                        bunifuCircleProgressbar2.ForeColor = Color.OrangeRed;
                    }

                }
                else if (cl_estatistica.calcularfemenino()>cl_estatistica.calcularmasculino())
                {
                    if (cl_estatistica.calcularmasculino() < 20)
                    {
                        bunifuCircleProgressbar1.ProgressColor = Color.Red;
                        bunifuCircleProgressbar1.ForeColor = Color.Red;
                    }
                    else if (cl_estatistica.calcularmasculino() >= 20 && cl_estatistica.calcularmasculino()<50)
                    {
                        bunifuCircleProgressbar1.ProgressColor = Color.OrangeRed;
                        bunifuCircleProgressbar1.ForeColor = Color.OrangeRed;
                    }

                }
            }
            else
            {
                MessageBox.Show("tens de inscrever candidatos");
            }
        }

        

       

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            escrever_candidato escrever = new escrever_candidato();
            escrever.ShowDialog();
        }
    }
}
