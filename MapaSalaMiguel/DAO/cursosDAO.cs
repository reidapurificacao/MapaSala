using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using model.entidades;
using System.Data;

namespace MapaSala.DAO
{
    public class cursosDAO
    {
        // "LS05MPF" servidor em rede; "Localhost" próprio PC
        private string LinhaConexao = "Server=LS05MPF;Database=AULA_DS;User Id=sa;Password=admsasql;";
        private SqlConnection Conexao;
        public cursosDAO()
        {
            Conexao = new SqlConnection(LinhaConexao);
        }

        public void Inserir(CursosEntidade professor)
        {
            Conexao.Open();
            string query = "Insert into Cursos (Nome, Ano, Id, Periodo, Vagas) Values (@nome,@Ano, @Id, @Periodo, @Vagas)";
            SqlCommand comando = new SqlCommand(query, Conexao);
            SqlParameter parametro1 = new SqlParameter("@nome", professor.Nome);
            SqlParameter parametro2 = new SqlParameter("@Ano", professor.Ano);
            SqlParameter parametro3 = new SqlParameter("@Id", professor.Id);
            SqlParameter parametro4 = new SqlParameter("@Vagas", professor.Vagas);
            SqlParameter parametro5 = new SqlParameter("@Periodo", professor.Periodo);
            comando.Parameters.Add(parametro1);
            comando.Parameters.Add(parametro2);
            comando.Parameters.Add(parametro3);
            comando.Parameters.Add(parametro4);
            comando.Parameters.Add(parametro5);
            comando.ExecuteNonQuery();
            Conexao.Close();
        }
        public DataTable PreencherComboBox()
        {
            DataTable dataTable = new DataTable();

            string query = "SELECT Id, Nome FROM Cursos";

            using (SqlConnection connection = new SqlConnection(LinhaConexao))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                try
                {
                    // Preenche o DataTable com os dados da consulta
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    // Lida com erros, se necessário
                    throw new Exception("Erro ao acessar os dados: " + ex.Message);
                }
            }

            return dataTable;
        }
        public DataTable obtercurso()
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "Select * From Cursos Order BY Id desc";
            SqlCommand comando = new SqlCommand(query, Conexao);
            comando.ExecuteReader();
            SqlDataReader leitura = comando.ExecuteReader();
            foreach (var atributos in typeof(CursosEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (leitura.HasRows)
            {
                while (leitura.Read())
                {
                    CursosEntidade curso = new CursosEntidade();
                    curso.Id = Convert.ToInt32(leitura[0]);
                    curso.Nome = leitura[1].ToString();
                    curso.Ano = Convert.ToInt32(leitura[2]);
                    curso.Periodo = leitura[3].ToString();
                    curso.Vagas = Convert.ToBoolean(leitura[4]);
                    dt.Rows.Add(curso.Linha());

                    
                }
            }
            Conexao.Close();
            return dt;

        }
        public DataTable pesquisar(string pesquisar)
        {
            DataTable dt = new DataTable();
            Conexao.Open();
            string query = "";


            if (string.IsNullOrEmpty(pesquisar))
            {
                query = "SELECT Id,Ano,Nome, Periodo, Vagas FROM Cursos order by Id desc";
            }
            else
            {
                query = "SELECT Id,Ano,Nome, Periodo, Vagas FROM Cursos where Nome LIKE '%" + pesquisar + "%' Order by Id desc";
            }

            SqlCommand comando = new SqlCommand(query, Conexao);

            SqlDataReader leitura = comando.ExecuteReader();
            foreach (var atributos in typeof(CursosEntidade).GetProperties())
            {
                dt.Columns.Add(atributos.Name);
            }
            if (leitura.HasRows)
            {
                while (leitura.Read())
                {
                    CursosEntidade cursos = new CursosEntidade();
                    cursos.Id = Convert.ToInt32(leitura[0]);
                    cursos.Ano = Convert.ToInt32(leitura[1]);
                    cursos.Nome = leitura[2].ToString();
                    cursos.Periodo = leitura[3].ToString();
                    cursos.Vagas = Convert.ToBoolean(leitura[4]);
                    dt.Rows.Add(cursos.Linha());


                }
            }
            Conexao.Close();
            return dt;

        }
        /*  public int Id { get; set; }
        public int Ano { get; set; }
        public string Nome { get; set; }
        public string Periodo { get; set; }
        public bool Vagas { get; set; }*/




    }
}

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model.entidades
{
    public class CursosEntidade
    {
       

public int Id { get; set; }
public int Ano { get; set; }
public string Nome { get; set; }
public string Periodo { get; set; }
public bool Vagas { get; set; }
public Object[] Linha()
{
    return new object[] { Id, Nome, Ano, Periodo, Vagas };
}

    }
}
*/



