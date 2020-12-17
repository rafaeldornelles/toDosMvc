using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using toDosMvc.Models;

namespace toDosMvc.Dados.Dao
{
    interface IQuery<T> where T:BaseModel
    {
        public IEnumerable<T> Listar();
        public T BuscarPorId(int id);
    }
}
