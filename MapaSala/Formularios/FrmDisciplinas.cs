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
using MapaSala.DAO;
namespace MapaSala.Formularios
{
    public partial class FrmDisciplinas : Form
    {
        DataTable dados;//novo
        int LinhaSelecionada;
        public FrmDisciplinas()
        {
            InitializeComponent();
            dados = new DataTable();//novo
            dtGridDisci.DataSource = dados;
            foreach (var atributos in typeof(DisciplinasEntidade).GetProperties())//novo
            {
                dados.Columns.Add(atributos.Name);
            }

            dados.Rows.Add(1, "Matematica", "MAT", true);
            dados.Rows.Add(2, "Portugues", "PORT", true);
            dados.Rows.Add(3, "Física", "FIS",true);
        }

        private void chkDisponivelpro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtApelidopro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvarpro_Click(object sender, EventArgs e)
        {
            DisciplinasEntidade d = new DisciplinasEntidade();
            d.Id = Convert.ToInt32(NumDisci.Value);
            d.Sigla = txtSigla.Text;
            d.Nome = txtNomeDisci.Text;
            d.Ativo = chkAtivoDisci.Checked;

            dados.Rows.Add( d.linha());//novo
            Limpardados();
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
            DataGridViewRow a = dtGridDisci.Rows[LinhaSelecionada];//fazer isso em todas
            a.Cells[0].Value = NumDisci.Value;
            a.Cells[1].Value = txtNomeDisci.Text;
            a.Cells[2].Value = txtSigla.Text;
            a.Cells[3].Value = chkAtivoDisci.Checked;
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

        private void dtGridDisci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;//fazer isso em todos


            txtNomeDisci.Text = dtGridDisci.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtSigla.Text = dtGridDisci.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            NumDisci.Value = Convert.ToInt32(dtGridDisci.Rows[LinhaSelecionada].Cells[0].Value);
            chkAtivoDisci.Checked = Convert.ToBoolean(dtGridDisci.Rows[LinhaSelecionada].Cells[3].Value);

        }
    }
}
