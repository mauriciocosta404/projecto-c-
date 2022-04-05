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
    public partial class menu_principal : Form
    {
        public menu_principal()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (array.cont != 0)
            {
                estatistica_de_funcionario  candidato = new estatistica_de_funcionario();
            candidato.ShowDialog();
            }else
            {
                MessageBox.Show("nenhum candidato para fazer estatistica");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            escrever_candidato escrever = new escrever_candidato();
            escrever.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (array.cont != 0)
            {
                listar_candidato listar = new listar_candidato();
            listar.ShowDialog();
            }else
            {
                MessageBox.Show("nenhum candidato listado");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            integrantes_do_grupo integrante = new integrantes_do_grupo();
            integrante.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (array.cont!=0) { 
            consultar_candidato consultar = new consultar_candidato();
            consultar.ShowDialog();
            }else
            {
                MessageBox.Show("para consultar candidatos deves inscrever candidatos");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (array.cont != 0)
            {
                eliminar_candidato eliminar = new eliminar_candidato();
            eliminar.ShowDialog();
            }
            else
            {
                MessageBox.Show("nenhum candidato para eliminar");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (array.cont != 0)
            {
                actualizar_candidat actualizar = new actualizar_candidat();
            actualizar.ShowDialog();
            }
            else
            {
                MessageBox.Show("nenhum candidato para actualizar");
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void doubleBitmapControl1_Click(object sender, EventArgs e)
        {

        }

        private void menu_principal_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.SeaGreen;
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.SeaGreen;
            Application.Exit();
        }

        private void bunifuFlatButton1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            escrever_candidato escrever = new escrever_candidato();
            escrever.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (array.cont != 0)
            {
                eliminar_candidato eliminar = new eliminar_candidato();
                eliminar.ShowDialog();
            }
            else
            {
                MessageBox.Show("nenhum candidato para eliminar");
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (array.cont != 0)
            {
                listar_candidato listar = new listar_candidato();
                listar.ShowDialog();
            }
            else
            {
                MessageBox.Show("nenhum candidato listado");
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            integrantes_do_grupo integrantes = new integrantes_do_grupo();
            integrantes.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (array.cont != 0)
            {
                estatistica_de_funcionario candidato = new estatistica_de_funcionario();
                candidato.ShowDialog();
            }
            else
            {
                MessageBox.Show("nenhum candidato para fazer estatistica");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (array.cont != 0)
            {
                consultar_candidato consultar = new consultar_candidato();
                consultar.ShowDialog();
            }
            else
            {
                MessageBox.Show("para consultar candidatos deves inscrever candidatos");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (array.cont != 0)
            {
                actualizar_candidat actualizar = new actualizar_candidat();
                actualizar.ShowDialog();
            }
            else
            {
                MessageBox.Show("nenhum candidato para actualizar");
            }
        }
    }
}
