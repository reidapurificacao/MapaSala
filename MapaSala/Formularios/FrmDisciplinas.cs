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
    public partial class FrmDisciplinas : Form
    {
        DataTable dados;
        int LinhaSelecionada;
        public FrmDisciplinas()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridDisci.DataSource = dados;
        }

        private void chkDisponivelpro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtApelidopro_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtGridSalas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalvarpro_Click(object sender, EventArgs e)
        {
            DisciplinasEntidade d = new DisciplinasEntidade();
            d.Id = Convert.ToInt32(NumDisci.Value);
            d.Sigla = txtSigla.Text;
            d.Nome = txtNomeDisci.Text;
            d.Ativo = chkAtivoDisci.Checked;

            dados.Add(d);
            Limpardados();
        }

        private void txtDisciplina_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdpro_TextChanged(object sender, EventArgs e)
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

        private void txtNomepro_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmDisciplinas_Load(object sender, EventArgs e)
        {

        }

        private void NumDisci_ValueChanged(object sender, EventArgs e)
        {

        }
        private void Limpardados()//Criei a função de apagar em todas e fiz o botao de limpar dados em todas dia 11/06/2024
        {
            txtNomeDisci.Text = "";
            txtSigla.Text = "";
            NumDisci.Value = 0;
            chkAtivoDisci.Checked = false;


        }
        private void BtnLimparDisci_Click(object sender, EventArgs e)
        {
            Limpardados();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            dtGridDisci.Rows.RemoveAt(LinhaSelecionada);
        }
    }
}
