using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolarHub.Estrutura.Model;

namespace SolarHub.Estrutura.Repository
{
    // Todas as informações do SolarHub relacionadas a interface de acesso da bateria, denominada HUB são acessadas pelas estruturas HubRepository e HubController
    public class HubRepository
    {
        private readonly string _connectionString = "User Id=RM551716;Password=200398;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=oracle.fiap.com.br)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));";

        // --- Grid de energia ---

        // Pega os valores do Grid de energia do banco de dados baseado no ID do usuário logado
        public List<GridItem> ListarGridItems(int idUsuarioLogado)
        {
            var lista = new List<GridItem>();

            
            using (var connection = new OracleConnection(_connectionString))
            {
                string query = "SELECT Nome, Prioridade, Voltagem FROM SolarhubGridItem WHERE OwnerID =" + idUsuarioLogado;

                var command = new OracleCommand(query, connection);

                connection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var gridItem = new GridItem
                    {
                        Nome = reader["Nome"].ToString(),
                        Prioridade = reader["Prioridade"].ToString(),
                        Voltagem = Convert.ToInt32(reader["Voltagem"])
                    };

                    lista.Add(gridItem);
                }
            }
            return lista;
        }

        // Adiciona um novo item ao Grid de energia no banco de dados
        public bool InserirGridItem(int ID, string Nome, string Prioridade, int Voltagem)
        {
            using (var connection = new OracleConnection(_connectionString))
            {
                string query = "INSERT INTO SolarhubGridItem (OwnerID, Nome, Prioridade, Voltagem) VALUES (:ID, :Nome, :Prioridade, :Voltagem)";

                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter("OwnerID", ID));
                    command.Parameters.Add(new OracleParameter("Nome", Nome));
                    command.Parameters.Add(new OracleParameter("Prioridade", Prioridade));
                    command.Parameters.Add(new OracleParameter("Voltagem", Voltagem));

                    connection.Open();
                    int resultado = command.ExecuteNonQuery();

                    switch (resultado)
                    {
                        case 0:
                            return false;
                        default:
                            return true;
                    }
                }
            }
        }

        // Remover um item do grid de energia do banco de dados
        public bool RemoverGridItem(int ID, string Nome)
        {
            using (var connection = new OracleConnection(_connectionString))
            {
                string query = "DELETE FROM SolarhubGridItem WHERE OwnerID = :ID AND Nome = :Nome";

                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter("ID", ID));
                    command.Parameters.Add(new OracleParameter("Nome", Nome));

                    connection.Open();
                    int resultado = command.ExecuteNonQuery();

                    switch (resultado)
                    {
                        case 0:
                            return false;
                        default:
                            return true;
                    }
                }
            }
        }

        // Conta a quantidade de itens no Grid de energia
        public int ContarGridItens(int ID)
        {
            int quantidade = 0;

            using (var connection = new OracleConnection(_connectionString))
            {
                string query = "SELECT COUNT(*) FROM SolarhubGridItem WHERE OwnerID = :ownerID";

                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter("ownerID", ID));

                    connection.Open();
                    quantidade = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return quantidade;
        }


        // --- Paineis Solares ---

        // Pega os valores dos paineis solares do banco de dados baseado no ID do usuário logado
        public List<SolarPanel> ListarPaineisSolares(int idUsuarioLogado)
        {
            var lista = new List<SolarPanel>();

            using (var connection = new OracleConnection(_connectionString))
            {
                string query = "SELECT Nome, Ligado, EnergiaGerada FROM SolarhubSolarPanel WHERE OwnerID =" + idUsuarioLogado;

                var command = new OracleCommand(query, connection);

                connection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var solarPanel = new SolarPanel
                    {
                        Nome = reader["Nome"].ToString(),
                        Ligado = Convert.ToInt32(reader["Ligado"]) == 1,
                        EnergiaGerada = Convert.ToInt32(reader["EnergiaGerada"])
                    };

                    lista.Add(solarPanel);
                }
            }
            return lista;
        }

        // Adiciona um novo item aos Paineis Solares no banco de dados
        public bool InserirSolarPanel(int ID, string Nome, int Ligado, double EnergiaGerada)
        {
            using (var connection = new OracleConnection(_connectionString))
            {
                string query = "INSERT INTO SolarhubSolarPanel (OwnerID, Nome, Ligado, EnergiaGerada) VALUES (:ID, :Nome, :Ligado, :EnergiaGerada)";

                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter("OwnerID", ID));
                    command.Parameters.Add(new OracleParameter("Nome", Nome));
                    command.Parameters.Add(new OracleParameter("Ligado", Ligado));
                    command.Parameters.Add(new OracleParameter("EnergiaGerada", EnergiaGerada));

                    connection.Open();
                    int resultado = command.ExecuteNonQuery();

                    switch (resultado)
                    {
                        case 0:
                            return false;
                        default:
                            return true;
                    }
                }
            }
        }

        // Remover um painel solar do banco de dados
        public bool RemoverSolarPanel(int ID, string Nome)
        {
            using (var connection = new OracleConnection(_connectionString))
            {
                string query = "DELETE FROM SolarhubSolarPanel WHERE OwnerID = :ID AND Nome = :Nome";

                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter("ID", ID));
                    command.Parameters.Add(new OracleParameter("Nome", Nome));

                    connection.Open();
                    int resultado = command.ExecuteNonQuery();

                    switch (resultado)
                    {
                        case 0:
                            return false;
                        default:
                            return true;
                    }
                }
            }
        }

        // Conta a quantidade de Paineis Solares
        public int ContarSolarPanel(int ID)
        {
            int quantidade = 0;

            using (var connection = new OracleConnection(_connectionString))
            {
                string query = "SELECT COUNT(*) FROM SolarhubSolarPanel WHERE OwnerID = :ownerID";

                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter("ownerID", ID));

                    connection.Open();
                    quantidade = Convert.ToInt32(command.ExecuteScalar());
                }
            }

            return quantidade;
        }

        // Soma a energia gerada por todos os paineis solares do usuário logado
        public double SomarEnergiaGerada(int ID)
        {
            double energiaTotal = 0;

            using (var connection = new OracleConnection(_connectionString))
            {
                string query = "SELECT NVL(SUM(EnergiaGerada), 0) FROM SolarhubSolarPanel WHERE OwnerID = :ownerID";

                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter("ownerID", ID));

                    connection.Open();
                    object resultado = command.ExecuteScalar();
                    energiaTotal = Convert.ToDouble(resultado);
                }
            }

            return energiaTotal;
        }


        // --- Bateria ---

        // Pega o estatus da bateria (ligada/desligada) do banco de dados e retorna uma string com o status
        public string GetBateriaState(int idUsuario)
        {
            using (var connection = new OracleConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT Ligado FROM SolarhubBateria WHERE OwnerID = :idUsuario";

                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter("idUsuario", idUsuario));

                    object result = command.ExecuteScalar();

                    if (result == null)
                    {
                        return "Bateria não encontrada";
                    }

                    int ligado = Convert.ToInt32(result);

                    return ligado == 1 ? "Estado do Grid de energia Solarhub: Ativado" : "Estado do Grid de energia Solarhub: Desativado";
                }
            }
        }

        // Altera o estado da bateria (ligada/desligada) no banco de dados
        public string AlternarEstadoBateria(int idUsuario)
        {
            using (var connection = new OracleConnection(_connectionString))
            {
                connection.Open();

                // Primeiro, ler o valor atual de Ligado
                string selectQuery = "SELECT Ligado FROM SolarhubBateria WHERE OwnerID = :idUsuario";

                using (var selectCommand = new OracleCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.Add(new OracleParameter("idUsuario", idUsuario));

                    object result = selectCommand.ExecuteScalar();

                    if (result == null)
                    {
                        throw new Exception("Bateria não encontrada.");
                    }

                    int ligadoAtual = Convert.ToInt32(result);
                    int novoValor = ligadoAtual == 1 ? 0 : 1;

                    // Atualizar com o novo valor
                    string updateQuery = "UPDATE SolarhubBateria SET Ligado = :novoValor WHERE OwnerID = :idUsuario";

                    using (var updateCommand = new OracleCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.Add(new OracleParameter("novoValor", novoValor));
                        updateCommand.Parameters.Add(new OracleParameter("idUsuario", idUsuario));

                        updateCommand.ExecuteNonQuery();
                    }

                    return novoValor == 1 ? "Estado do Grid de energia Solarhub: Ativado" : "Estado do Grid de energia Solarhub: Desativado";
                }
            }
        }

        // Get nos valores de Capacidade e Energia armazenada no banco de dados
        public double GetBateriaEnergiaArmazenada(int idUsuario)
        {
            using (var connection = new OracleConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT EnergiaArmazenada FROM SolarhubBateria WHERE OwnerID = :idUsuario";

                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter("idUsuario", idUsuario));

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            double energiaArmazenada = Convert.ToDouble(reader["EnergiaArmazenada"]);

                            return energiaArmazenada;
                        }
                        else
                        {
                            return 000;
                        }
                    }
                }
            }
        }


    }
}
