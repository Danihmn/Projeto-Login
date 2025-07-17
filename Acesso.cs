using System.Data;

namespace WinFormsApp1
{
    public partial class Acesso : Form
    {
        public Acesso()
        {
            InitializeComponent();
        }

        // Evento do botão para acessar o login do usuário
        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text.ToLower();
            string senha = textBox2.Text;

            try
            {
                if (email != "" && senha != "")
                {
                    DataTable consulta = Consulta.ConsultarConta(email, senha);

                    if (consulta.Rows.Count > 0)
                    {
                        MessageBox.Show("Id: " + consulta.Rows[0].ItemArray[0].ToString() +
                            "\nNome: " + consulta.Rows[0].ItemArray[1].ToString() +
                            "\nE-mail: " + consulta.Rows[0].ItemArray[2].ToString(), "Logado com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao tentar logar");
                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
