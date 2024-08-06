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

    public partial class FrmCursos : Form
    {
        DataTable dados;//novo
        int LinhaSelecionada;
        public FrmCursos()
        {
            InitializeComponent();
            dados = new DataTable();//novo
            dtGridCursos.DataSource = dados;
            foreach (var atributos in typeof(CursoEntidades).GetProperties())//novo
            {
                dados.Columns.Add(atributos.Name);
            }

            dados.Rows.Add(1, "Matematica", "Manha", true);
            dados.Rows.Add(2, "Portugues", "Tarde", true);
            dados.Rows.Add(3, "Física", "Noite", true);
        }

        private void FrmCursos_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarTurno_Click(object sender, EventArgs e)
        {
            CursoEntidades c = new CursoEntidades();
            c.id = Convert.ToInt32(NumCurso.Value);
            c.Turno = txtTurno.Text;
            c.nome = txtNomeCurso.Text;
            c.Ativo = chkAtivoTurno.Checked;
            dados.Rows.Add(c.linha());
            Limpardados();
        }
        private void Limpardados() //Criei a função de apagar em todas e fiz o botao de limpar dados em todas dia 11/06/2024
        {
            txtNomeCurso.Text = "";
            txtTurno.Text = "";
            NumCurso.Value = 0;
        }
        private void BtnLimparCurso_Click(object sender, EventArgs e)
        {
            Limpardados();
        }

        private void NumCurso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chkAtivoTurno_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dtGridCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtGridCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LinhaSelecionada = e.RowIndex;
            txtNomeCurso.Text = dtGridCursos.Rows[LinhaSelecionada].Cells[1].Value.ToString();
            txtTurno.Text = dtGridCursos.Rows[LinhaSelecionada].Cells[2].Value.ToString();
            NumCurso.Value = Convert.ToInt32(dtGridCursos.Rows[LinhaSelecionada].Cells[0].Value);
            chkAtivoTurno.Checked = Convert.ToBoolean(dtGridCursos.Rows[LinhaSelecionada].Cells[3].Value);
        }

        private void btmeditarcurso_Click(object sender, EventArgs e)
        {

            DataGridViewRow a = dtGridCursos.Rows[LinhaSelecionada];//fazer isso em todas
            a.Cells[0].Value = NumCurso.Value;
            a.Cells[1].Value = txtNomeCurso.Text;
            a.Cells[2].Value = txtTurno.Text;
            a.Cells[3].Value = chkAtivoTurno.Checked;
        }

        private void BtnExcluircursos_Click(object sender, EventArgs e)
        {
            dtGridCursos.Rows.RemoveAt(LinhaSelecionada);
        }
    }
}
