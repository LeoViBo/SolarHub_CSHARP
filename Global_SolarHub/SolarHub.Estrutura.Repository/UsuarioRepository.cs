using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarHub.Estrutura.Repository
{
    public class UsuarioRepository
    {
        private readonly string _connectionString = "User Id=RM551716;Password=200398;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=oracle.fiap.com.br)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));";
        public int UsuarioLogadoID = 0;
        public bool validarLogin(string Username, string Password)
        {
            using (OracleConnection connection = new OracleConnection(_connectionString))
            {
                string query = "SELECT ID FROM SolarhubUsers WHERE Username = :username AND Password = :password";
                connection.Open();

                using (OracleCommand cmd = new OracleCommand(query, connection))
                {
                    cmd.Parameters.Add(new OracleParameter("username", Username));
                    cmd.Parameters.Add(new OracleParameter("password", Password));

                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        UsuarioLogadoID = Convert.ToInt32(resultado);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public int GetUsuarioLogadoID()
        {
            return UsuarioLogadoID;
        }
    }
}
