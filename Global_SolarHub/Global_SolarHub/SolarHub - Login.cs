using SolarHub.Estrutura.Controller;

namespace Global_SolarHub
{
    public partial class FormLogin : Form
    {
        UsuarioController controller = new UsuarioController();
        public FormLogin()
        {
            InitializeComponent();
            label_LoginError.Visible = false;
        }

        // Botão de login
        private void button_Login_Click(object sender, EventArgs e)
        {
            // Faz validação do usuário e senha no banco de dados
            bool validacao = controller.validarUsuarioSenha(textBox_Username.Text, textBox_Password.Text);
            int idUsuarioLogado = controller.GetUsuarioLogadoID();

            if (validacao)
            {
                MessageBox.Show("Login realizado com sucesso!");
                SolarHub_Menu menu = new SolarHub_Menu(idUsuarioLogado);

                // Mostra o menu e esconde o formulário de login porque se fechar o login, o programa será encerrado
                menu.Show();
                this.Hide();

                // Linka o do evento FormClosed para fechar o formulário de login quando o menu for fechado
                menu.FormClosed += (s, args) => this.Close();
            }
            else
            {
                // Mostra mensaem de erro e limpa os campos de usuário e senha
                label_LoginError.Visible = true;
                textBox_Username.Clear();
                textBox_Password.Clear();
            }
        }
    }
}
