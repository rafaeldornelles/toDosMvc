using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using toDosMvc.Models;

namespace toDosMvc.Dados.Dao
{
    interface IComando<T> where T:BaseModel
    {
        public void Add(T elemento);
        public void Update(T elemento);
        public void Delete(T elemento);
    }
}
