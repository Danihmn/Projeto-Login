namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // Evento do bot�o de cadastrar
        private void button2_Click(object sender, EventArgs e)
        {
            Cadastro janelaCadastro = new Cadastro();
            janelaCadastro.ShowDialog();
        }
    }
}
