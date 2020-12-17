using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using toDosMvc.Models;

namespace toDosMvc.Dados.Dao
{
    public class BaseDao<T> where T: BaseModel
    {
        private protected readonly ApplicationContext _dbContext;

        public BaseDao(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
            _dbset = dbContext.Set<T>();
        }

        private protected readonly DbSet<T> _dbset;
    }
}
