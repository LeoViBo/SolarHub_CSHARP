namespace Global_SolarHub
{
    partial class SolarHub_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            Bateria = new ProgressBar();
            button_OnOffGrid = new Button();
            button_PaineisSolares = new Button();
            button_GridEnergia = new Button();
            button_Dashboard = new Button();
            button_FecharAplicacao = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            button_AdicionarItem = new Button();
            button_RemoverItem = new Button();
            dataGridView_Default = new DataGridView();
            button_LigarPainel = new Button();
            button_DesligarPainel = new Button();
            label_BateriaEstado = new Label();
            label_QntPaineisSolares = new Label();
            label_EnergiaGerada = new Label();
            label_BateriaRestante = new Label();
            label_QntItensGrid = new Label();
            label_Value_QntItensGrid = new Label();
            label_Value_QntPaineisSolares = new Label();
            label_Value_EnergiaGerada = new Label();
            label_Value_BateriaRestante = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Default).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Location = new Point(970, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(8, 12);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Bateria
            // 
            Bateria.BackColor = Color.White;
            Bateria.Location = new Point(924, 3);
            Bateria.Name = "Bateria";
            Bateria.Size = new Size(46, 23);
            Bateria.TabIndex = 12;
            Bateria.Value = 80;
            // 
            // button_OnOffGrid
            // 
            button_OnOffGrid.BackColor = SystemColors.ScrollBar;
            button_OnOffGrid.Font = new Font("Segoe UI", 8F);
            button_OnOffGrid.Location = new Point(4, 128);
            button_OnOffGrid.Name = "button_OnOffGrid";
            button_OnOffGrid.Size = new Size(155, 29);
            button_OnOffGrid.TabIndex = 14;
            button_OnOffGrid.Text = "Ligar/Desligar Grid";
            button_OnOffGrid.UseVisualStyleBackColor = false;
            button_OnOffGrid.Click += button_OnOffGrid_Click;
            // 
            // button_PaineisSolares
            // 
            button_PaineisSolares.BackColor = SystemColors.ControlLight;
            button_PaineisSolares.Font = new Font("Segoe UI", 10F);
            button_PaineisSolares.Location = new Point(4, 46);
            button_PaineisSolares.Name = "button_PaineisSolares";
            button_PaineisSolares.Size = new Size(154, 30);
            button_PaineisSolares.TabIndex = 15;
            button_PaineisSolares.Text = "Paineis Solares";
            button_PaineisSolares.UseVisualStyleBackColor = false;
            button_PaineisSolares.Click += button_PaineisSolares_Click;
            // 
            // button_GridEnergia
            // 
            button_GridEnergia.BackColor = SystemColors.ControlLight;
            button_GridEnergia.Font = new Font("Segoe UI", 10F);
            button_GridEnergia.Location = new Point(4, 82);
            button_GridEnergia.Name = "button_GridEnergia";
            button_GridEnergia.Size = new Size(154, 30);
            button_GridEnergia.TabIndex = 16;
            button_GridEnergia.Text = "Grid de Energia";
            button_GridEnergia.UseVisualStyleBackColor = false;
            button_GridEnergia.Click += button_GridEnergia_Click;
            // 
            // button_Dashboard
            // 
            button_Dashboard.BackColor = SystemColors.ControlLight;
            button_Dashboard.Font = new Font("Segoe UI", 10F);
            button_Dashboard.Location = new Point(4, 10);
            button_Dashboard.Name = "button_Dashboard";
            button_Dashboard.Size = new Size(154, 30);
            button_Dashboard.TabIndex = 17;
            button_Dashboard.Text = "Dashboard";
            button_Dashboard.UseVisualStyleBackColor = false;
            button_Dashboard.Click += button_Dashboard_Click;
            // 
            // button_FecharAplicacao
            // 
            button_FecharAplicacao.BackColor = SystemColors.ControlLight;
            button_FecharAplicacao.Font = new Font("Segoe UI", 10F);
            button_FecharAplicacao.Location = new Point(4, 231);
            button_FecharAplicacao.Name = "button_FecharAplicacao";
            button_FecharAplicacao.Size = new Size(154, 30);
            button_FecharAplicacao.TabIndex = 18;
            button_FecharAplicacao.Text = "Fechar Aplicação";
            button_FecharAplicacao.UseVisualStyleBackColor = false;
            button_FecharAplicacao.Click += button_Desligar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox2.Location = new Point(166, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(4, 274);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveCaption;
            pictureBox3.Location = new Point(-15, 118);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(185, 4);
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ActiveCaption;
            pictureBox4.Location = new Point(-15, 221);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(185, 4);
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // button_AdicionarItem
            // 
            button_AdicionarItem.BackColor = SystemColors.ScrollBar;
            button_AdicionarItem.Font = new Font("Segoe UI", 8F);
            button_AdicionarItem.Location = new Point(4, 158);
            button_AdicionarItem.Name = "button_AdicionarItem";
            button_AdicionarItem.Size = new Size(154, 28);
            button_AdicionarItem.TabIndex = 22;
            button_AdicionarItem.Text = "Adicionar item";
            button_AdicionarItem.UseVisualStyleBackColor = false;
            button_AdicionarItem.Click += button_AdicionarItem_Click;
            // 
            // button_RemoverItem
            // 
            button_RemoverItem.BackColor = SystemColors.ScrollBar;
            button_RemoverItem.Font = new Font("Segoe UI", 8F);
            button_RemoverItem.Location = new Point(4, 187);
            button_RemoverItem.Name = "button_RemoverItem";
            button_RemoverItem.Size = new Size(154, 28);
            button_RemoverItem.TabIndex = 23;
            button_RemoverItem.Text = "Remover Item";
            button_RemoverItem.UseVisualStyleBackColor = false;
            button_RemoverItem.Click += button_RemoverItem_Click;
            // 
            // dataGridView_Default
            // 
            dataGridView_Default.AllowUserToAddRows = false;
            dataGridView_Default.AllowUserToDeleteRows = false;
            dataGridView_Default.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Default.Location = new Point(184, 32);
            dataGridView_Default.Name = "dataGridView_Default";
            dataGridView_Default.ReadOnly = true;
            dataGridView_Default.RowHeadersWidth = 51;
            dataGridView_Default.Size = new Size(786, 229);
            dataGridView_Default.TabIndex = 24;
            // 
            // button_LigarPainel
            // 
            button_LigarPainel.BackColor = SystemColors.ScrollBar;
            button_LigarPainel.Font = new Font("Segoe UI", 8F);
            button_LigarPainel.Location = new Point(4, 158);
            button_LigarPainel.Name = "button_LigarPainel";
            button_LigarPainel.Size = new Size(155, 28);
            button_LigarPainel.TabIndex = 25;
            button_LigarPainel.Text = "Adicionar Painel Solar";
            button_LigarPainel.UseVisualStyleBackColor = false;
            button_LigarPainel.Click += button_LigarPainel_Click;
            // 
            // button_DesligarPainel
            // 
            button_DesligarPainel.BackColor = SystemColors.ScrollBar;
            button_DesligarPainel.Font = new Font("Segoe UI", 8F);
            button_DesligarPainel.Location = new Point(4, 187);
            button_DesligarPainel.Name = "button_DesligarPainel";
            button_DesligarPainel.Size = new Size(156, 28);
            button_DesligarPainel.TabIndex = 26;
            button_DesligarPainel.Text = "Remover Painel Solar";
            button_DesligarPainel.UseVisualStyleBackColor = false;
            button_DesligarPainel.Click += button_DesligarPainel_Click;
            // 
            // label_BateriaEstado
            // 
            label_BateriaEstado.AutoSize = true;
            label_BateriaEstado.Location = new Point(180, 6);
            label_BateriaEstado.Name = "label_BateriaEstado";
            label_BateriaEstado.Size = new Size(328, 20);
            label_BateriaEstado.TabIndex = 27;
            label_BateriaEstado.Text = "Estado do Grid de energia Solarhub: Desativado";
            // 
            // label_QntPaineisSolares
            // 
            label_QntPaineisSolares.Font = new Font("Segoe UI", 15F);
            label_QntPaineisSolares.Location = new Point(404, 82);
            label_QntPaineisSolares.Name = "label_QntPaineisSolares";
            label_QntPaineisSolares.Size = new Size(190, 80);
            label_QntPaineisSolares.TabIndex = 28;
            label_QntPaineisSolares.Text = "Quantidade de Paineis Solares:";
            label_QntPaineisSolares.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_EnergiaGerada
            // 
            label_EnergiaGerada.Font = new Font("Segoe UI", 15F);
            label_EnergiaGerada.Location = new Point(600, 82);
            label_EnergiaGerada.Name = "label_EnergiaGerada";
            label_EnergiaGerada.Size = new Size(178, 80);
            label_EnergiaGerada.TabIndex = 29;
            label_EnergiaGerada.Text = "Energia gerada no dia:";
            label_EnergiaGerada.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_BateriaRestante
            // 
            label_BateriaRestante.Font = new Font("Segoe UI", 15F);
            label_BateriaRestante.Location = new Point(784, 82);
            label_BateriaRestante.Name = "label_BateriaRestante";
            label_BateriaRestante.Size = new Size(162, 80);
            label_BateriaRestante.TabIndex = 30;
            label_BateriaRestante.Text = "Bateria Restante:";
            label_BateriaRestante.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_QntItensGrid
            // 
            label_QntItensGrid.Font = new Font("Segoe UI", 15F);
            label_QntItensGrid.Location = new Point(211, 82);
            label_QntItensGrid.Name = "label_QntItensGrid";
            label_QntItensGrid.Size = new Size(187, 80);
            label_QntItensGrid.TabIndex = 31;
            label_QntItensGrid.Text = "Quantidade de itens no Grid:";
            label_QntItensGrid.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Value_QntItensGrid
            // 
            label_Value_QntItensGrid.Font = new Font("Segoe UI", 20F);
            label_Value_QntItensGrid.Location = new Point(211, 164);
            label_Value_QntItensGrid.Name = "label_Value_QntItensGrid";
            label_Value_QntItensGrid.Size = new Size(187, 55);
            label_Value_QntItensGrid.TabIndex = 32;
            label_Value_QntItensGrid.Text = "000";
            label_Value_QntItensGrid.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Value_QntPaineisSolares
            // 
            label_Value_QntPaineisSolares.Font = new Font("Segoe UI", 20F);
            label_Value_QntPaineisSolares.Location = new Point(404, 164);
            label_Value_QntPaineisSolares.Name = "label_Value_QntPaineisSolares";
            label_Value_QntPaineisSolares.Size = new Size(190, 55);
            label_Value_QntPaineisSolares.TabIndex = 33;
            label_Value_QntPaineisSolares.Text = "000";
            label_Value_QntPaineisSolares.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Value_EnergiaGerada
            // 
            label_Value_EnergiaGerada.Font = new Font("Segoe UI", 20F);
            label_Value_EnergiaGerada.Location = new Point(600, 164);
            label_Value_EnergiaGerada.Name = "label_Value_EnergiaGerada";
            label_Value_EnergiaGerada.Size = new Size(178, 55);
            label_Value_EnergiaGerada.TabIndex = 34;
            label_Value_EnergiaGerada.Text = "000";
            label_Value_EnergiaGerada.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_Value_BateriaRestante
            // 
            label_Value_BateriaRestante.Font = new Font("Segoe UI", 20F);
            label_Value_BateriaRestante.Location = new Point(784, 164);
            label_Value_BateriaRestante.Name = "label_Value_BateriaRestante";
            label_Value_BateriaRestante.Size = new Size(162, 55);
            label_Value_BateriaRestante.TabIndex = 35;
            label_Value_BateriaRestante.Text = "000";
            label_Value_BateriaRestante.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SolarHub_Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(982, 273);
            Controls.Add(label_Value_BateriaRestante);
            Controls.Add(label_Value_EnergiaGerada);
            Controls.Add(label_Value_QntPaineisSolares);
            Controls.Add(label_Value_QntItensGrid);
            Controls.Add(label_QntItensGrid);
            Controls.Add(label_BateriaRestante);
            Controls.Add(label_EnergiaGerada);
            Controls.Add(label_QntPaineisSolares);
            Controls.Add(label_BateriaEstado);
            Controls.Add(button_DesligarPainel);
            Controls.Add(button_LigarPainel);
            Controls.Add(dataGridView_Default);
            Controls.Add(button_RemoverItem);
            Controls.Add(button_AdicionarItem);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(button_FecharAplicacao);
            Controls.Add(button_Dashboard);
            Controls.Add(button_GridEnergia);
            Controls.Add(button_PaineisSolares);
            Controls.Add(button_OnOffGrid);
            Controls.Add(pictureBox1);
            Controls.Add(Bateria);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SolarHub_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SolarHub - Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Default).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ProgressBar Bateria;
        private Button button_OnOffGrid;
        private Button button_PaineisSolares;
        private Button button_GridEnergia;
        private Button button_Dashboard;
        private Button button_FecharAplicacao;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button button_AdicionarItem;
        private Button button_RemoverItem;
        private DataGridView dataGridView_Default;
        private Button button_LigarPainel;
        private Button button_DesligarPainel;
        private Label label_BateriaEstado;
        private Label label_QntPaineisSolares;
        private Label label_EnergiaGerada;
        private Label label_BateriaRestante;
        private Label label_QntItensGrid;
        private Label label_Value_QntItensGrid;
        private Label label_Value_QntPaineisSolares;
        private Label label_Value_EnergiaGerada;
        private Label label_Value_BateriaRestante;
    }
}