using Model.Entitidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaSala.Formularios
{
    public partial class FrmProfessores : Form
    {
        DataTable dados;//novo
        int LinhaSelecionada;
        public FrmProfessores()
        {
            InitializeComponent();
            dados = new DataTable();//novo
            dtGridPro.DataSource = dados;
            foreach (var atributos in typeof(DisciplinasEntidade).GetProperties())//novo
            {
                dados.Columns.Add(atributos.Name);
            }

            dados.Rows.Add(1, "Matematica", "MAT", true);
            dados.Rows.Add(2, "Portugues", "PORT", true);
            dados.Rows.Add(3, "Física", "FIS", true);
        }
        private void dtGridSalas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNumCadeira_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProfessoresEntidade p = new ProfessoresEntidade();
            p.Id = Convert.ToInt32(NumID.Value);
            p.Apelido = txtApelidopro.Text;
            p.Nome = txtNomepro.Text;
            dados.Rows.Add(p.linha());
            Limpardados();
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

        private void txtDisciplina_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApelidopro_TextChanged(object sender, EventArgs e)
        {

        }
        private void Limpardados()//Criei a função de apagar em todas e fiz o botao de limpar dados em todas dia 11/06/2024
        {
            txtNomepro.Text = "";
            txtApelidopro.Text = "";
            NumID.Value = 0;
        }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            Limpardados();
        }

        private void NumID_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtGridPro_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            LinhaSelecionada = e.RowIndex;
            txtApelidopro.Text = dtGridPro.Rows[LinhaSelecionada].Cells[1].ToString();
            txtNomepro.Text = dtGridPro.Rows[LinhaSelecionada].Cells[2].ToString();
            NumID.Value = Convert.ToInt32(dtGridPro.Rows[LinhaSelecionada].Cells[0].Value);
        }
    }
}
