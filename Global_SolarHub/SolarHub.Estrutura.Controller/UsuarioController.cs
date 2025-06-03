using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolarHub.Estrutura.Repository;

namespace SolarHub.Estrutura.Controller
{
    public class UsuarioController
    {
        UsuarioRepository repositorio = new UsuarioRepository();
        public bool validarUsuarioSenha(string Username, string Password)
        {
            return repositorio.validarLogin(Username, Password);
        }
        public int GetUsuarioLogadoID()
        {
            return repositorio.GetUsuarioLogadoID();
        }
    }

}
