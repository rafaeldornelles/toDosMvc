using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using toDosMvc.Dados.Dao;
using toDosMvc.Models;
using toDosMvc.Services;

namespace toDosMvc.Controllers
{
    public class UsuarioController : Controller
    {
        private IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            this._usuarioService = usuarioService;
        }

        public IActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EfetuarCadastro([FromForm] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _usuarioService.AdicionarUsuario(usuario);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            IEnumerable<Usuario> usuarios = _usuarioService.ListarUsuarios();
            return View(usuarios);
        }
    }
}
