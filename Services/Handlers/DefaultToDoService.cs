using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using toDosMvc.Dados.Dao;
using toDosMvc.Models;
using toDosMvc.Models.ViewModels;

namespace toDosMvc.Services
{
    public class DefaultToDoService : IToDoService
    {
        private IToDoDao _todoDao;
        private IUsuarioDao _usuarioDao;

        public DefaultToDoService(IToDoDao todoDao, IUsuarioDao usuarioDao)
        {
            _todoDao = todoDao;
            _usuarioDao = usuarioDao;
        }

        public IEnumerable<ToDo> ListarToDos() => _todoDao.Listar();

        public void AdicionarToDo(ToDo toDo) => _todoDao.Add(toDo);

        public CadastroToDoViewModel MontarCadastroViewModel()
        {
            ToDo toDo = new ToDo();
            IEnumerable<Usuario> usuarios = _usuarioDao.Listar();

            return new CadastroToDoViewModel(toDo, usuarios);
        }
    }
}
