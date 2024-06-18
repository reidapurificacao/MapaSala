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
        DataTable dados;//novo
        int LinhaSelecionada;
        public FrmUsuarios()
        {
            InitializeComponent();
            dados = new DataTable();//novo
            dtGridUser.DataSource = dados;
            foreach (var atributos in typeof(UsuariosEntidade).GetProperties())//novo
            {
                dados.Columns.Add(atributos.Name);
            }

            dados.Rows.Add(1, "Wagner", "wawawawa@gmail.com","blava", true);
            dados.Rows.Add(2, "lUCAS", "leifas@gmail.com","xioxo", true);
            dados.Rows.Add(3, "Raphael", "papa@gmail.com","fafassf", true);
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
            dados.Rows.Add(u.linha());
            Limpardados();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtGmailUser_TextChanged(object sender, EventArgs e)
        {

        }
        private void Limpardados()//Criei a função de apagar em todas e fiz o botao de limpar dados em todas dia 11/06/2024
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

        private void dtGridUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtNomeUser.Text = dtGridUser.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtGmailUser.Text = dtGridUser.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            txtSenhaUser.Text = dtGridUser.Rows[LinhaSelecionada].Cells[3].Value.ToString();
            NumUser.Value = Convert.ToInt32(dtGridUser.Rows[LinhaSelecionada].Cells[0].Value);
            chkAtivoUser.Checked = Convert.ToBoolean(dtGridUser.Rows[LinhaSelecionada].Cells[4].Value);

        }

        private void BtnExcluircursos_Click(object sender, EventArgs e)
        {
            dtGridUser.Rows.RemoveAt(LinhaSelecionada);
        }

        private void btmeditarcurso_Click(object sender, EventArgs e)
        {
            DataGridViewRow a = dtGridUser.Rows[LinhaSelecionada];//fazer isso em todas
            a.Cells[0].Value = NumUser.Value;
            a.Cells[1].Value = txtNomeUser.Text;
            a.Cells[2].Value = txtGmailUser.Text;
            a.Cells[3].Value = txtSenhaUser.Text;
            a.Cells[4].Value = chkAtivoUser.Checked;
        }
    }
}
