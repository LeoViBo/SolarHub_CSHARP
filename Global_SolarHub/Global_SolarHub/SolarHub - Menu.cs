using Microsoft.VisualBasic;
using SolarHub.Estrutura.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Global_SolarHub
{
    public partial class SolarHub_Menu : Form
    {
        private readonly HubController _HubController = new HubController();
        private int ID_Logado = 0;
        public SolarHub_Menu(int _ID_Logado)
        {
            InitializeComponent();
            HideUI();
            ID_Logado = _ID_Logado;
            AlterarTextoDeGrid();
            button_Dashboard_Click(this, EventArgs.Empty);
        }

        // --- Outras funções ---

        // Esconde todas as Interfaces que não são botões de navegação
        public void HideUI()
        {
            dataGridView_Default.Hide();
            button_OnOffGrid.Hide();
            button_AdicionarItem.Hide();
            button_RemoverItem.Hide();
            button_LigarPainel.Hide();
            button_DesligarPainel.Hide();
            label_QntItensGrid.Hide();
            label_Value_QntItensGrid.Hide();
            label_QntPaineisSolares.Hide();
            label_Value_QntPaineisSolares.Hide();
            label_EnergiaGerada.Hide();
            label_Value_EnergiaGerada.Hide();
            label_BateriaRestante.Hide();
            label_Value_BateriaRestante.Hide();
        }

        // Atualiza o texto do label de estado da bateria com o estado atual da bateria (Ativada/Desativada)
        public void AlterarTextoDeGrid()
        {
            string texto = _HubController.GetBateriaState(ID_Logado);
            label_BateriaEstado.Text = texto;
        }

        // Atualiza o DataGridView com os itens dos paineis solares
        private void CarregarDataSolarPanel()
        {
            var lista = _HubController.ListarPaineisSolares(ID_Logado);
            dataGridView_Default.DataSource = lista;
        }

        // Atualiza o DataGridView com os itens do Grid de energia
        private void CarregarDataGrid()
        {
            var lista = _HubController.ListarGridItems(ID_Logado);
            dataGridView_Default.DataSource = lista;
        }

        // --- Botões de navegação ---

        // Botão de navegação para Dashboard
        public void button_Dashboard_Click(object sender, EventArgs e)
        {
            HideUI();
            label_Value_QntItensGrid.Text = _HubController.ContarGridItens(ID_Logado).ToString();
            label_Value_QntPaineisSolares.Text = _HubController.ContarSolarPanel(ID_Logado).ToString();
            label_Value_EnergiaGerada.Text = _HubController.SomarEnergiaGerada(ID_Logado).ToString();
            label_Value_BateriaRestante.Text = _HubController.GetBateriaEnergiaArmazenada(ID_Logado).ToString();
            label_QntItensGrid.Show();
            label_Value_QntItensGrid.Show();
            label_QntPaineisSolares.Show();
            label_Value_QntPaineisSolares.Show();
            label_EnergiaGerada.Show();
            label_Value_EnergiaGerada.Show();
            label_BateriaRestante.Show();
            label_Value_BateriaRestante.Show();
        }

        // Botão de navegação para mostrar paines solares
        private void button_PaineisSolares_Click(object sender, EventArgs e)
        {
            HideUI();
            CarregarDataSolarPanel();
            dataGridView_Default.Show();
            button_LigarPainel.Show();
            button_DesligarPainel.Show();
        }

        // Botão de navegação para mostrar o Grid de energia, mostra também os botões de adicionar e remover itens e ligar/desligar o grid
        private void button_GridEnergia_Click(object sender, EventArgs e)
        {
            HideUI();
            CarregarDataGrid();
            dataGridView_Default.Show();
            button_OnOffGrid.Show();
            button_AdicionarItem.Show();
            button_RemoverItem.Show();
        }

        // Botão de navegação para fechar a aplicação
        public void button_Desligar_Click(object sender, EventArgs e)
        {
            HideUI();
            Application.Exit();
        }

        // --- Botões de Suporte ---

        // Botão de suporte para ligar/desligar o grid de energia
        private void button_OnOffGrid_Click(object sender, EventArgs e)
        {
            string text = _HubController.AlternarEstadoBateria(ID_Logado);
            label_BateriaEstado.Text = text;
        }

        // Botão de suporte para adicionar itens do grid de energia
        private void button_AdicionarItem_Click(object sender, EventArgs e)
        {
            string Nome = Interaction.InputBox("Digite o nome do item:", "Adicionar Item", "");

            string input = "";
            string Prioridade;
            int Voltagem;
            while (true)
            {
                input = Interaction.InputBox("Digite a prioridade: Alta, Media ou Baixa (O valor deve ser exatamente igual)", "Prioridade", "");

                if (input == "Alta" || input == "Media" || input == "Baixa")
                {
                    Prioridade = input;
                    break;
                }
                else
                {
                    MessageBox.Show("Prioridade inválida! Digite exatamente: Alta, Media ou Baixa.");
                }
            }

            while (true)
            {
                input = Interaction.InputBox("Digite a voltagem: 110 ou 220 (Digite apenas os números)", "Voltagem", "");

                if (input == "110" || input == "220")
                {
                    Voltagem = Convert.ToInt32(input);
                    break;
                }
                else
                {
                    MessageBox.Show("Voltagem inválida! Digite um número válido (ex: 110 ou 220).");
                }
            }

            bool Inserir = _HubController.InserirGridItem(ID_Logado, Nome, Prioridade, Voltagem);
            if (Inserir)
            {
                MessageBox.Show("Item adicionado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao adicionar item.");
            }

            CarregarDataGrid();
        }


        // Botão de suporte para remover itens do grid de energia
        private void button_RemoverItem_Click(object sender, EventArgs e)
        {
            string Nome = Interaction.InputBox("Digite o nome do item que deseja remover:", "Remover Item", "");

            bool Remover = _HubController.RemoverGridItem(ID_Logado, Nome);
            if (Remover)
            {
                MessageBox.Show("Item removido com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao remover item.");
            }

            CarregarDataGrid();
        }

        // Botão de suporte para adicionar os paineis solares
        private void button_LigarPainel_Click(object sender, EventArgs e)
        {
            string Nome = Interaction.InputBox("Digite o nome do painel solar que deseja adicionar:", "Adicionar Painel Solar", "");
  
            bool InserirNovo = _HubController.InserirSolarPanel(ID_Logado, Nome, 1, 0);
            if (InserirNovo)
            {
                MessageBox.Show("Painel solar adicionado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao adicionar painel solar.");
            }
            CarregarDataSolarPanel();
        }

        // Botão de suporte para remover os paineis solares
        private void button_DesligarPainel_Click(object sender, EventArgs e)
        {
            string Nome = Interaction.InputBox("Digite o nome do painel solar que deseja remover:", "Remover Painel Solar", "");
            bool Remover = _HubController.RemoverSolarPanel(ID_Logado, Nome);
            if (Remover)
            {
                MessageBox.Show("Painel solar removido com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao remover painel solar.");
            }
            CarregarDataSolarPanel();
        }
    }
}
