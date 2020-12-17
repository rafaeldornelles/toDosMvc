using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using toDosMvc.Models;

namespace toDosMvc.Dados.Dao
{
    public class UsuarioDao : BaseDao<Usuario>, IQuery<Usuario>, IComando<Usuario>, IUsuarioDao
    {
        public UsuarioDao(ApplicationContext dbContext) : base(dbContext)
        {
        }

        public void Add(Usuario usuario)
        {
            _dbset.Add(usuario);
            _dbContext.SaveChanges();
        }

        public Usuario BuscarPorId(int id)
        {
            return _dbset.Include(u=>u.ToDos).FirstOrDefault(u=>u.Id == id);
        }

        public void Delete(Usuario usuario)
        {
            _dbset.Remove(usuario);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Usuario> Listar()
        {
            return _dbset.Include(u=>u.ToDos);
        }

        public void Update(Usuario usuario)
        {
            _dbset.Update(usuario);
            _dbContext.SaveChanges();
        }
    }
}
