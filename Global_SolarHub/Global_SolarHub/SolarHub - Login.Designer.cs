namespace Global_SolarHub
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_Login = new Button();
            label_Title = new Label();
            label_Username = new Label();
            label_Password = new Label();
            textBox_Username = new TextBox();
            textBox_Password = new TextBox();
            label_LoginError = new Label();
            Bateria_Base = new ProgressBar();
            Bateria_Ponta = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Bateria_Ponta).BeginInit();
            SuspendLayout();
            // 
            // button_Login
            // 
            button_Login.BackColor = SystemColors.ControlLight;
            button_Login.Font = new Font("Segoe UI", 15F);
            button_Login.Location = new Point(409, 207);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(172, 54);
            button_Login.TabIndex = 1;
            button_Login.Text = "Fazer login";
            button_Login.UseVisualStyleBackColor = false;
            button_Login.Click += button_Login_Click;
            // 
            // label_Title
            // 
            label_Title.AutoSize = true;
            label_Title.Font = new Font("Segoe UI", 30F);
            label_Title.Location = new Point(372, 18);
            label_Title.Name = "label_Title";
            label_Title.Size = new Size(246, 67);
            label_Title.TabIndex = 2;
            label_Title.Text = "Solar Hub";
            // 
            // label_Username
            // 
            label_Username.AutoSize = true;
            label_Username.Font = new Font("Segoe UI", 15F);
            label_Username.Location = new Point(26, 142);
            label_Username.Name = "label_Username";
            label_Username.Size = new Size(213, 35);
            label_Username.TabIndex = 3;
            label_Username.Text = "Nome do Usuário";
            // 
            // label_Password
            // 
            label_Password.AutoSize = true;
            label_Password.Font = new Font("Segoe UI", 15F);
            label_Password.Location = new Point(545, 145);
            label_Password.Name = "label_Password";
            label_Password.Size = new Size(82, 35);
            label_Password.TabIndex = 4;
            label_Password.Text = "Senha";
            // 
            // textBox_Username
            // 
            textBox_Username.BackColor = SystemColors.ControlLight;
            textBox_Username.Font = new Font("Segoe UI", 15F);
            textBox_Username.Location = new Point(245, 142);
            textBox_Username.MaxLength = 20;
            textBox_Username.Name = "textBox_Username";
            textBox_Username.Size = new Size(275, 41);
            textBox_Username.TabIndex = 5;
            // 
            // textBox_Password
            // 
            textBox_Password.BackColor = SystemColors.ControlLight;
            textBox_Password.Font = new Font("Segoe UI", 15F);
            textBox_Password.Location = new Point(633, 142);
            textBox_Password.MaxLength = 20;
            textBox_Password.Name = "textBox_Password";
            textBox_Password.PasswordChar = '*';
            textBox_Password.Size = new Size(313, 41);
            textBox_Password.TabIndex = 6;
            textBox_Password.UseSystemPasswordChar = true;
            // 
            // label_LoginError
            // 
            label_LoginError.Font = new Font("Segoe UI", 10F);
            label_LoginError.ForeColor = Color.Red;
            label_LoginError.Location = new Point(294, 102);
            label_LoginError.Name = "label_LoginError";
            label_LoginError.Size = new Size(382, 25);
            label_LoginError.TabIndex = 7;
            label_LoginError.Text = "Login invalido: Usuario e/ou senha incorretos";
            label_LoginError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Bateria_Base
            // 
            Bateria_Base.BackColor = Color.White;
            Bateria_Base.Location = new Point(914, 12);
            Bateria_Base.Name = "Bateria_Base";
            Bateria_Base.Size = new Size(46, 23);
            Bateria_Base.TabIndex = 10;
            Bateria_Base.Value = 80;
            // 
            // Bateria_Ponta
            // 
            Bateria_Ponta.BackColor = SystemColors.ControlLight;
            Bateria_Ponta.Location = new Point(960, 18);
            Bateria_Ponta.Name = "Bateria_Ponta";
            Bateria_Ponta.Size = new Size(8, 12);
            Bateria_Ponta.TabIndex = 11;
            Bateria_Ponta.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(982, 273);
            Controls.Add(Bateria_Ponta);
            Controls.Add(Bateria_Base);
            Controls.Add(label_LoginError);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Username);
            Controls.Add(label_Password);
            Controls.Add(label_Username);
            Controls.Add(label_Title);
            Controls.Add(button_Login);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SolarHub - Login";
            ((System.ComponentModel.ISupportInitialize)Bateria_Ponta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_Login;
        private Label label_Title;
        private Label label_Username;
        private Label label_Password;
        private TextBox textBox_Username;
        private TextBox textBox_Password;
        private Label label_LoginError;
        private ProgressBar Bateria_Base;
        private PictureBox Bateria_Ponta;
    }
}
