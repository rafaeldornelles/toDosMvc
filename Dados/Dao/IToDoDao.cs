using System.Collections.Generic;
using toDosMvc.Models;

namespace toDosMvc.Dados.Dao
{
    public interface IToDoDao
    {
        void Add(ToDo toDo);
        ToDo BuscarPorId(int id);
        void Delete(ToDo toDo);
        IEnumerable<ToDo> Listar();
        void Update(ToDo toDO);
    }
}