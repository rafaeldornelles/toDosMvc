using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace toDosMvc.Models
{
    public abstract class BaseModel
    {
        [DataMember]
        public int Id {get; protected set;}
    }

    public class Usuario:BaseModel
    {
        [DataMember]
        [Required(ErrorMessage ="Nome é obrigatório.")]
        [MinLength(4, ErrorMessage ="Nome deve ter pelo menos 4 letras.")]
        public string Nome { get; set; } = "";
        [DataMember]
        [Required(ErrorMessage ="Selecione um item da lista.")]
        public Genero Genero { get; set; }

        public List<ToDo> ToDos { get; } = new List<ToDo>();
    }

    public class ToDo : BaseModel
    {
        [Required(ErrorMessage = "A tarefa deve ter um título.")]
        [MinLength(3, ErrorMessage = "Titulo deve ter pelo menos 3 caracteres.")]
        [DataMember]
        public string Titulo { get; set; } = "";
        [DataMember]
        public string Conteudo { get; set; } = "";
        [DataMember]
        [Required]
        public DateTime DataCriacao { get; set; } = DateTime.Today;
        [DataMember]
        [Required(ErrorMessage = "Selecione um Status.")]
        public ToDoStatus? Status { get; set; } = null;
        [DataMember]
        [Required(ErrorMessage ="Selecione um usuário.")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }

    public enum Genero{
        Masculino,
        Feminino,
        Outros
    }

    public enum ToDoStatus
    {
        Futuro,
        Pendente,
        Concluído
    }
}