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

    public partial class FrmCursos : Form
    {
        BindingSource dados;
        
        public FrmCursos()
        {
            InitializeComponent();
            dados = new BindingSource();
            dtGridCursos.DataSource = dados;
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
            dados.Add(c);
        }
    }
}
