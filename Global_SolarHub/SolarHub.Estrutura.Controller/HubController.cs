using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolarHub.Estrutura.Repository;
using SolarHub.Estrutura.Model;

namespace SolarHub.Estrutura.Controller
{
    // Todas as informações do SolarHub relacionadas a interface de acesso da bateria, denominada HUB são acessadas pelas estruturas HubRepository e HubController
    public class HubController
    {
        private readonly HubRepository _repository = new HubRepository();

        // --- Grid de energia ---

        // Lista os itens do grid de energia
        public List<GridItem> ListarGridItems(int ID)
        {
            return _repository.ListarGridItems(ID);
        }
        // Insere um novo item no grid de energia
        public bool InserirGridItem(int ID, string Nome, string Prioridade, int Voltagem)
        {
            return _repository.InserirGridItem(ID, Nome, Prioridade, Voltagem);
        }

        // Remove um item do grid de energia
        public bool RemoverGridItem(int ID, string Nome)
        {
            return _repository.RemoverGridItem(ID, Nome);
        }

        // Conta o número de itens no grid de energia
        public int ContarGridItens(int ID)
        {
            return _repository.ContarGridItens(ID);
        }

        // --- Paineis Solares ---

        // Lista os paineis solares
        public List<SolarPanel> ListarPaineisSolares(int UsuarioLogadoID)
        {
            return _repository.ListarPaineisSolares(UsuarioLogadoID);
        }

        // Insere um novo painel solar
        public bool InserirSolarPanel(int ID, string Nome, int Ligado, int EnergiaGerada)
        {
            return _repository.InserirSolarPanel(ID, Nome, Ligado, EnergiaGerada);
        }

        // Remove um painel solar
        public bool RemoverSolarPanel(int ID, string Nome)
        {
            return _repository.RemoverSolarPanel(ID, Nome);

        }

        // Conta o número de paineis solares
        public int ContarSolarPanel(int ID)
        {
            return _repository.ContarSolarPanel(ID);
        }

        // Soma a energia gerada por todos os paineis solares
        public double SomarEnergiaGerada(int ID)
        {
            return _repository.SomarEnergiaGerada(ID);
        }

        // --- Bateria ---

        public string GetBateriaState(int ID)
        {
            return _repository.GetBateriaState(ID);
        }

        // Altera o estado da bateria (ligada/desligada)
        public string AlternarEstadoBateria(int ID)
        {
            return _repository.AlternarEstadoBateria(ID);
        }

        // Get dos valores de Capacidade e Energia Armazenada da bateria
        public double GetBateriaEnergiaArmazenada(int ID)
        {
            return _repository.GetBateriaEnergiaArmazenada(ID);
        }
    }
}
