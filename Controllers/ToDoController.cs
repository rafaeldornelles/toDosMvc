using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using toDosMvc.Models;
using toDosMvc.Models.ViewModels;
using toDosMvc.Services;

namespace toDosMvc.Controllers
{
    public class ToDoController : Controller
    {
        private IToDoService _toDoService;

        public ToDoController(IToDoService toDoService, IUsuarioService usuarioService)
        {
            _toDoService = toDoService;
        }

        public IActionResult Index()
        {
            IEnumerable<ToDo> toDos = _toDoService.ListarToDos();
            return View(toDos);
        }        
        public IActionResult Cadastro(int usuario)
        {
            CadastroToDoViewModel viewModel = _toDoService.MontarCadastroViewModel();
            if (viewModel.Usuarios.Any())
            {
                viewModel.ToDo.UsuarioId = usuario;
                return View(viewModel);
            }
            return Redirect("/Usuario/Cadastro");
        }

        public IActionResult EfetuarCadastro([FromForm] ToDo toDo)
        {
            if (ModelState.IsValid)
            {
                _toDoService.AdicionarToDo(toDo);
            }
            return RedirectToAction("Index");
        }
    }
}
