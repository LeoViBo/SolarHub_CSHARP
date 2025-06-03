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

        // Bot�o de login
        private void button_Login_Click(object sender, EventArgs e)
        {
            // Faz valida��o do usu�rio e senha no banco de dados
            bool validacao = controller.validarUsuarioSenha(textBox_Username.Text, textBox_Password.Text);
            int idUsuarioLogado = controller.GetUsuarioLogadoID();

            if (validacao)
            {
                MessageBox.Show("Login realizado com sucesso!");
                SolarHub_Menu menu = new SolarHub_Menu(idUsuarioLogado);

                // Mostra o menu e esconde o formul�rio de login porque se fechar o login, o programa ser� encerrado
                menu.Show();
                this.Hide();

                // Linka o do evento FormClosed para fechar o formul�rio de login quando o menu for fechado
                menu.FormClosed += (s, args) => this.Close();
            }
            else
            {
                // Mostra mensaem de erro e limpa os campos de usu�rio e senha
                label_LoginError.Visible = true;
                textBox_Username.Clear();
                textBox_Password.Clear();
            }
        }
    }
}
