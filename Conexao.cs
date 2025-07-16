using System.Data.SQLite;

namespace WinFormsApp1
{
    #region Sessao de conexao
    /// <summary>
    /// Classe responsável por abrir conexão com o banco de dados
    /// </summary>
    internal class Conexao
    {
        /// <summary>
        /// Método responsável por abrir conexão com o banco de dados
        /// </summary>
        /// <returns>Retorna a conexão aberta</returns>
        public static SQLiteConnection ObterConexao()
        {
            SQLiteConnection conexao = new SQLiteConnection(@"Data Source = C:\\Users\\danie\\Dev.NET\\Projetos\\Projeto Login\\usuarios.db");
            conexao.Open();

            return conexao;
        }
    }
    #endregion
}
