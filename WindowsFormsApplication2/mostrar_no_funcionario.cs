﻿using System;
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
    public partial class mostrar_no_funcionario : Form
    {
        public mostrar_no_funcionario()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mostrar_no_funcionario_Load(object sender, EventArgs e)
        {
            label1.Text = dados_do_funcionario.nomes;
            label2.Text = dados_do_funcionario.telefone.ToString();
            label3.Text = dados_do_funcionario.idade.ToString();
            label4.Text = dados_do_funcionario.salario.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            menu_principal menu = new menu_principal();
            menu.ShowDialog();
        }
    }
}
