using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace toDosMvc.Models
{
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
}