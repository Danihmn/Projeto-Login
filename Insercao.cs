namespace WinFormsApp1
{
    /// <summary>
    /// Classe responsável por inserir dados no banco de dados
    /// </summary>
    internal class Insercao
    {
        /// <summary>
        /// Método responsável por inserir os dados do usuário no banco de dados
        /// </summary>
        /// <param name="nome">Nome do usuário a ser inserido</param>
        /// <param name="email">E-mail do usuário a ser inserido</param>
        /// <param name="senha">Senha do usuário a ser inserida</param>
        public static void InserirDados(string nome, string email, string senha)
        {
            using (var conexao = Conexao.ObterConexao())
            {
                try
                {
                    var comando = conexao.CreateCommand();
                    comando.CommandText = "INSERT INTO usuarios (nome, email, senha) VALUES (@nome, @email, @senha);";

                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@senha", senha);
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir os dados. " + ex.Message);
                    Thread.Sleep(3000);
                    throw;
                }
            }
        }
    }
}
