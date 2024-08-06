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
    public partial class frmSalas : Form
    {
        DataTable dados;//novo
        int LinhaSelecionada;
        public frmSalas()
        {
            InitializeComponent();
            dados = new DataTable();//novo
            dtGridSalas.DataSource = dados;
            foreach (var atributos in typeof(SalasEntidade).GetProperties())//novo
            {
                dados.Columns.Add(atributos.Name);
            }

            dados.Rows.Add(1, "21", 20, 40, true, true);
            dados.Rows.Add(2, "maker", 0, 35, true, true);
            dados.Rows.Add(3, "11", 10, 24, true, true);
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
            dados.Rows.Add(sala.linha());
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
        private void Limpardados()//Criei a função de apagar em todas e fiz o botao de limpar dados em todas dia 11/06/2024
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

        private void dtGridSalas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtNome.Text = dtGridSalas.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtNumCadeira.Value = Convert.ToInt32(dtGridSalas.Rows[LinhaSelecionada].Cells[3].Value);
            txtNumPc.Value = Convert.ToInt32(dtGridSalas.Rows[LinhaSelecionada].Cells[2].Value);
            chkDisponivel.Checked = Convert.ToBoolean(dtGridSalas.Rows[LinhaSelecionada].Cells[4].Value);
            chkIsLab.Checked = Convert.ToBoolean(dtGridSalas.Rows[LinhaSelecionada].Cells[5].Value);
        }

        private void BtnExcluircursos_Click(object sender, EventArgs e)
        {
            dtGridSalas.Rows.RemoveAt(LinhaSelecionada);
        }

        private void btmeditarcurso_Click(object sender, EventArgs e)
        {
            DataGridViewRow a = dtGridSalas.Rows[LinhaSelecionada];//fazer isso em todas
            a.Cells[0].Value = NumSalas.Value;
            a.Cells[1].Value = txtNome.Text;
            a.Cells[2].Value = txtNumPc.Value;
            a.Cells[3].Value = txtNumCadeira.Value;
            a.Cells[4].Value = chkIsLab.Checked;
            a.Cells[5].Value = chkDisponivel.Checked;
        }
    }
}
