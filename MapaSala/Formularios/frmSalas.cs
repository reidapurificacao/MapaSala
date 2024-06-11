﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Entitidades;

namespace MapaSala.Formularios
{
    public partial class frmSalas : Form
    {
        BindingSource dados;
        public frmSalas()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridSalas.DataSource = dados;
        }

        private void frmSalas_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalasEntidade sala = new SalasEntidade();
            sala.Id = Convert.ToInt32(NumSalas.Text);
            sala.Nome = txtNome.Text;
            sala.IsLab = chkIsLab.Checked;
            sala.NumeroCadeiras = Convert.ToInt32(txtNumCadeira.Value);
            sala.NumeroComputadores = Convert.ToInt32(txtNumPc.Value);
            sala.Disponivel = chkDisponivel.Checked;

            dados.Add(sala);
            Limpardados();
        }

        private void txtNumCadeira_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtGridSalas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNumPc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chkDisponivel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkIsLab_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
        private void Limpardados()
        {
            txtNome.Text = "";
            txtNumPc.Text = "";
            NumSalas.Value = 0;
            txtNumPc.Value = 0;
            txtNumCadeira.Value = 0;
            chkDisponivel.Checked = false;
            chkIsLab.Checked = false;

        }
        private void BtnLimparSalas_Click(object sender, EventArgs e)
        {
            Limpardados();
        }

        private void NumSalas_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
