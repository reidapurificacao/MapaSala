using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaSala.DAO
{
    class CursosDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public CursosDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }

        public object Curso { get; private set; }

        public void Inserir(CursoEntidades curso)
        {
            Conexao.Open();
            string query = "Insert into Curso (Nome, Turno,Ativo) Values(@Nome, @Turno,@Ativo)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@Nome", curso.Nome);
            SqlParameter parametro2 = new SqlParameter("@Turno", curso.Turno);
            SqlParameter parametro3 = new SqlParameter("@Turno", curso.Ativo);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public DataTable ObterProfessores()
        {
            Conexao.Open();
            string query = "SELECT Id, Nome, Turno, Ativo from Cursos Order by Id desc";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlDataReader Leitura = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(Leitura);
            Conexao.Close();
            return dt;
        }

    }
}

