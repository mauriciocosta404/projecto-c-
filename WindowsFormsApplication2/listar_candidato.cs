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
    public partial class listar_candidato : Form
    {
        public listar_candidato()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listar_candidato_Load(object sender, EventArgs e)
        {
            try { 
            dataGridView1.Rows.Add(array.contador);
            for (int l = 0; l < array.contador; l++)
             {
                dataGridView1[0, l].Value = array.nomes[l];
                dataGridView1[1, l].Value = array.curso[l];
                dataGridView1[2, l].Value = array.sexo[l];
                dataGridView1[3, l].Value = array.bi[l];
                dataGridView1[4, l].Value = array.idades[l];
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("nenhum candidato listado");
            }

          
         //   dataGridView1[0, 1].Value = array.nomes[0];
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            escrever_candidato escrever = new escrever_candidato();
            escrever.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
