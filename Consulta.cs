using System.Data;
using System.Data.SQLite;

namespace WinFormsApp1
{
    #region Sessao de consulta
    /// <summary>
    /// Classe responsável por realizar consultas no banco de dados
    /// </summary>
    internal class Consulta
    {
        /// <summary>
        /// Método responsável por consultar o usuário no banco de dados
        /// </summary>
        /// <param name="email">E-mail do usuário a ser consultado</param>
        /// <param name="senha">Senha do usuário a ser consultada</param>
        /// <returns>Retorna o DataTable proveniente da consulta</returns>
        public static DataTable ConsultarConta(string email, string senha)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SQLiteConnection conexao = Conexao.ObterConexao())
                {
                    var comando = conexao.CreateCommand();
                    comando.CommandText = "SELECT * FROM usuarios WHERE email = @email AND senha = @senha;";

                    comando.Parameters.AddWithValue("email", email);
                    comando.Parameters.AddWithValue("senha", senha);

                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(comando);
                    dataAdapter.Fill(dataTable); // Preenche o DataTable
                }
            }
            catch
            {
                throw;
            }

            return dataTable;
        }

        /// <summary>
        /// Método responsável por verificar se a conta de um usuário já existe através do e-mail
        /// </summary>
        /// <param name="email">E-mail do usuário a ser verificado</param>
        /// <returns>verdadeiro se existir, falso caso contrário</returns>
        public static bool VerificarExistenciaConta(string email)
        {
            bool existe;
            DataTable dataTable = new DataTable();

            try
            {
                using (SQLiteConnection conexao = Conexao.ObterConexao())
                {
                    var comando = conexao.CreateCommand();
                    comando.CommandText = "SELECT * FROM usuarios WHERE email = @email;";

                    comando.Parameters.AddWithValue("email", email);

                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(comando);
                    dataAdapter.Fill(dataTable); // Preenche o DataTable
                }
            }
            catch
            {
                throw;
            }

            // Verificação
            if (dataTable.Rows.Count > 0)
            {
                existe = true;
            }
            else
            {
                existe = false;
            }

            return existe;
        }
    }
    #endregion
}