using System;
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
    public partial class FrmUsuarios : Form
    {
        BindingSource dados;
        public FrmUsuarios()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridUser.DataSource = dados;
        }

        private void txtNomepro_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvarpro_Click(object sender, EventArgs e)
        {
            UsuariosEntidade u = new UsuariosEntidade();
            u.Id = Convert.ToInt32(NumUser.Value);
            u.Senha = txtSenhaUser.Text;
            u.Login = txtGmailUser.Text;
            u.Nome = txtNomeUser.Text;
            u.Ativo = chkAtivoUser.Checked;
            dados.Add(u);
            Limpardados();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtGmailUser_TextChanged(object sender, EventArgs e)
        {

        }
        private void Limpardados()
        {
            txtNomeUser.Text = "";
            txtSenhaUser.Text = "";
            txtGmailUser.Text = "";
            NumUser.Value = 0;
            chkAtivoUser.Checked = false;

        }
        private void BtnLimparUser_Click(object sender, EventArgs e)
        {
            Limpardados();
        }
    }
}
