using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using toDosMvc.Models;

namespace toDosMvc.Dados.Dao
{
    public class ToDoDao : BaseDao<ToDo>, IQuery<ToDo>, IComando<ToDo>, IToDoDao
    {
        public ToDoDao(ApplicationContext contexto) : base(contexto) { }

        public void Add(ToDo toDo)
        {
            _dbset.Add(toDo);
            _dbContext.SaveChanges();
        }

        public ToDo BuscarPorId(int id)
        {
            return _dbset.Include(t=> t.Usuario).FirstOrDefault(t=> t.Id == id);
        }

        public void Delete(ToDo toDo)
        {
            _dbset.Remove(toDo);
            _dbContext.SaveChanges();
        }

        public IEnumerable<ToDo> Listar()
        {
            return _dbset.Include(t => t.Usuario);
        }

        public void Update(ToDo toDO)
        {
            _dbset.Update(toDO);
            _dbContext.SaveChanges();
        }
    }
}
