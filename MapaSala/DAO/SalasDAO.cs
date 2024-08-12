using Model.Entitidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapaSala.DAO
{
    class SalasDAO
    {
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public SalasDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }
        public void Inserir(SalasEntidade salas)
        {
            Conexao.Open();
            string query = "Insert into Salas (Nome, Disponivel) Values(@Nome, @Disponivel)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@Nome", salas.Nome);
            SqlParameter parametro2 = new SqlParameter("@Disponivel", salas.Disponivel);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public DataTable ObterProfessores()
        {
            Conexao.Open();
            string query = "SELECT Id,Nome,IsLab,NumeroCadeiras,NumeroComputadores,Disponivel from Salas Order by Id desc";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlDataReader Leitura = comando.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(Leitura);
            Conexao.Close();
            return dt;
        }

    }
}

