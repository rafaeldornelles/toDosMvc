using System.Collections.Generic;
using toDosMvc.Models;

namespace toDosMvc.Dados.Dao
{
    public interface IUsuarioDao
    {
        void Add(Usuario usuario);
        Usuario BuscarPorId(int id);
        void Delete(Usuario usuario);
        IEnumerable<Usuario> Listar();
        void Update(Usuario usuario);
    }
}