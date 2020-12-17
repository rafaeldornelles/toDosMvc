using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using toDosMvc.Dados.Dao;
using toDosMvc.Models;

namespace toDosMvc.Services
{
    public class DefaultUsuarioService : IUsuarioService
    {
        private IUsuarioDao _usuarioDao;

        public DefaultUsuarioService(IUsuarioDao usuarioDao)
        {
            this._usuarioDao = usuarioDao;
        }

        public IEnumerable<Usuario> ListarUsuarios() => _usuarioDao.Listar();

        public void AdicionarUsuario(Usuario usuario) => _usuarioDao.Add(usuario);
    }
}
