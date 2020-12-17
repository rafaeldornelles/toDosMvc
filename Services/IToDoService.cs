using System.Collections.Generic;
using toDosMvc.Models;
using toDosMvc.Models.ViewModels;

namespace toDosMvc.Services
{
    public interface IToDoService
    {
        IEnumerable<ToDo> ListarToDos();
        CadastroToDoViewModel MontarCadastroViewModel();

        void AdicionarToDo(ToDo toDo);
    }
}