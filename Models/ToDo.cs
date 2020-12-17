using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace toDosMvc.Models
{
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
}