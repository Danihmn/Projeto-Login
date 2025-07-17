namespace WinFormsApp1
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        // Evento do botão de cadastrar
        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text.ToUpper();
            string email = textBox2.Text.ToLower();
            string senha = textBox3.Text;
            string confirmarSenha = textBox4.Text; // Usado para evitar erros de escrita

            try
            {
                if (nome != "" && email != "" && senha != "" && confirmarSenha != "")
                {
                    if (senha == confirmarSenha)
                    {
                        // Verifica a existência de cadastro
                        bool existeCadastro = Consulta.VerificarExistenciaConta(email);

                        if (!existeCadastro)
                        {
                            // Realiza a inserção
                            Insercao.InserirDados(nome, email, senha);
                            MessageBox.Show("Usuário cadastrado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Já existe um usuário com esse e-mail");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Os campos de senha e confirmação são diferentes, tente novamente.");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos para cadastrar.");
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
