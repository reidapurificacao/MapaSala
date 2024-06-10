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
        BindingSource dados;
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

            dados.Add(d);
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
    }
}
