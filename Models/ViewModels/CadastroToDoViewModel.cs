using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace toDosMvc.Models.ViewModels
{
    public class CadastroToDoViewModel
    {
        public ToDo ToDo;
        public IEnumerable<Usuario> Usuarios;

        public CadastroToDoViewModel(ToDo toDo, IEnumerable<Usuario> usuarios)
        {
            this.ToDo = toDo;
            this.Usuarios = usuarios;
        }

        public IEnumerable<SelectListItem> UsuarioItems() => Usuarios.Select(u => new SelectListItem
        {
            Value = u.Id.ToString(),
            Text = u.Nome
        });
    }
}
