using System.Collections.Generic;
using toDosMvc.Models;

namespace toDosMvc.Services
{
    public interface IUsuarioService
    {
        void AdicionarUsuario(Usuario usuario);
        IEnumerable<Usuario> ListarUsuarios();
    }
}