using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Turma_CSharp
{
    static class DBConnect
    {
        //string de conexão
        private static string connect = "Data Source=Opalita;Initial Catalog=dbTurma_CSharp;" +
            "Integrated Security=True;Trust Server Certificate=True";
        
        //conexão com a base de dados
        public static SqlConnection DBConnecting()
        {
            SqlConnection connection = new SqlConnection(connect);
            connection.Open();
            return connection;
        }

        //Adicionar registo
        public static bool AddAluno(Alunos aluno, int id)
        {
            try
            {
                SqlConnection connection = DBConnecting();
                SqlCommand command = connection.CreateCommand();
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@numbAluno", aluno.NumbAluno);
                command.Parameters.AddWithValue("@nome", aluno.Nome);
                command.Parameters.AddWithValue("@telefone", aluno.Telefone);
                command.Parameters.AddWithValue("@morada", aluno.Morada);
                command.Parameters.AddWithValue("@dataNasc", aluno.DataNasc);
                command.Parameters.AddWithValue("@nota", aluno.Nota);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();

                string select = "SELECT * FROM Alunos WHERE N_Aluno = @numbAluno AND " +
                    "Nome = @nome AND Morada = @morada AND Telefone = @telefone AND " +
                    "Data_Nasc = @dataNasc AND Nota_Final = @nota";
                command.CommandText = select;
                da.SelectCommand = command;
                da.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    throw new Exception("Aluno já existe na base de dados");
                }

                string insert = "INSERT INTO Alunos " +
                    "(N_Aluno, Nome, Morada, Telefone, Data_Nasc, Nota_Final) " +
                    "VALUES (@numbAluno, @nome, @telefone, @morada, @dataNasc, @nota)";
                command.CommandText = insert;
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Dispose();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar aluno: " + ex.Message);
                return false;
            }
        }

        // Atualizar registo
        public static bool UpdateAluno(Alunos aluno, int id)
        {
            try
            {
                SqlConnection connection = DBConnecting();
                SqlCommand command = connection.CreateCommand();
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@numbAluno", aluno.NumbAluno);
                command.Parameters.AddWithValue("@nome", aluno.Nome);
                command.Parameters.AddWithValue("@telefone", aluno.Telefone);
                command.Parameters.AddWithValue("@morada", aluno.Morada);
                command.Parameters.AddWithValue("@dataNasc", aluno.DataNasc);
                command.Parameters.AddWithValue("@nota", aluno.Nota);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();

                string select = "SELECT * FROM Alunos WHERE N_Aluno = @numbAluno AND " +
                    "Nome = @nome AND Morada = @morada AND Telefone = @telefone AND " +
                    "Data_Nasc = @dataNasc AND Nota_Final = @nota";
                command.CommandText = select;
                da.SelectCommand = command;
                da.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    throw new Exception("Aluno já existe na base de dados");
                }

                string update = "UPDATE Alunos SET" +
                    "N_Aluno = @numbAluno, Nome = @nome, Morada = @morada, " +
                    "Telefone = @telefone, Data_Nasc = @dataNasc, " +
                    "Nota_Final = @nota WHERE id = @id";
                command.CommandText = update;
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar aluno: " + ex.Message);
                return false;
            }
        }

        // utilizar id selecionado apos pesquisa para carregar dados para edição
        public static DataTable GetAluno(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection connection = DBConnecting();
                SqlCommand command = connection.CreateCommand();
                command.Parameters.AddWithValue("@id", id);

                string selectId = "SELECT * FROM Alunos WHERE ID_Aluno = @id";
                command.CommandText = selectId;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                da.Fill(dt);
                command.Dispose();
                connection.Dispose();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro! Aluno não encontrado: " + ex.Message);
                return null;
            }
        }

        // Obter todos os alunos e lista-los
        public static DataTable GetAlunos(string item)
        {
            DataTable dt = new DataTable();

            try
            {
                SqlConnection connection = DBConnecting();
                SqlCommand command = connection.CreateCommand();
                string selectAll = "SELECT * FROM Alunos";

                if (item != "")
                {
                    command.Parameters.AddWithValue("@item", "%" + item + "%");
                    selectAll += " WHERE N_Aluno LIKE @item OR Nome LIKE @item OR " +
                        "Morada LIKE @item OR Telefone LIKE @item OR " +
                        "Data_Nasc LIKE @item OR Nota_Final LIKE @item";
                }
                command.CommandText = selectAll;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                da.Fill(dt);
                command.Dispose();
                connection.Dispose();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro! Registo não encontrado: " + ex.Message);
                return null;
            }
        }

        // Remover aluno
        public static bool DeleteAluno(int id)
        {
            try
            {
                SqlConnection connection = DBConnecting();
                SqlCommand command = connection.CreateCommand();

                command.Parameters.AddWithValue("@id", id);
                string delete = "DELETE FROM Alunos WHERE ID_Aluno = @id";
                command.CommandText = delete;
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro remover aluno: " + ex.Message);
                return false;
            }
        }

        // Calcular média de todos os alunos
        public static double MediaAlunos()
        {
            try
            {
                SqlConnection connection = DBConnecting();
                SqlCommand command = connection.CreateCommand();

                string selectMedia = "SELECT AVG(Nota_Final) FROM Alunos";
                command.CommandText = selectMedia;
                command.ExecuteScalar();

                object media = command.ExecuteScalar();

                command.Dispose();
                connection.Dispose();

                return Convert.ToDouble(media);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro! Não foi possível calcular a média: " + ex.Message);
                return 0;
            }
        }

        // Mostrar notas máximas
        public static DataTable NotaMax()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlConnection connection = DBConnecting();
                SqlCommand command = connection.CreateCommand();

                string selectMax = "SELECT * from Alunos where Nota_Final=" +
                    "(select MAX(Nota_Final) from Alunos)";
                command.CommandText = selectMax;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                da.Fill(dt);
                command.Dispose();
                connection.Dispose();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro! Registo não encontrado: " + ex.Message);
                return null;
            }
        }

        // Mostrar notas mínimas
        public static DataTable NotaMin()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlConnection connection = DBConnecting();
                SqlCommand command = connection.CreateCommand();

                string selectMin = "SELECT * from Alunos where Nota_Final=" +
                    "(select MIN(Nota_Final) from Alunos)";
                command.CommandText = selectMin;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                da.Fill(dt);
                command.Dispose();
                connection.Dispose();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro! Registo não encontrado: " + ex.Message);
                return null;
            }
        }

        // Mostrar alunos reprovados
        public static DataTable Reprovados()
        {
            DataTable dt = new DataTable();

            try
            {
                SqlConnection connection = DBConnecting();
                SqlCommand command = connection.CreateCommand();

                string selectRepr = "SELECT* from Alunos where Nota_Final < 9.5";
                command.CommandText = selectRepr;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                da.Fill(dt);
                command.Dispose();
                connection.Dispose();
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro! Registo não encontrado: " + ex.Message);
                return null;
            }
        }
    }
}
