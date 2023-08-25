﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(txtCodigo.Text, txtNome.Text);
            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Insert(0, txtCodigo.Text, txtNome.Text);
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void limpar()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            //dataGridView2.Rows.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Cells[0].RowIndex);
        }
    }
}
