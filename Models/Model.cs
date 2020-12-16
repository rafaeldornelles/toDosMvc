using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;

namespace toDosMvc.Models
{

    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options){}
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<ToDo> ToDos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pessoa>().HasKey(p => p.Id);
            modelBuilder.Entity<Pessoa>().HasMany(p=> p.ToDos).WithOne(t=> t.Usuario);

            modelBuilder.Entity<ToDo>().HasKey(t=> t.Id);
            modelBuilder.Entity<ToDo>().HasOne(t=> t.Usuario);
        }
    }

    public abstract class BaseModel
    {
        public int Id {get; protected set;}
    }

    public class Pessoa:BaseModel
    {
        public string Nome { get; set; }
        public Sexo sexo { get; set; }

        public List<ToDo> ToDos { get; } = new List<ToDo>();
    }

    public class ToDo:BaseModel
    {
        public string Titulo { get; set; }
        public DateTime DataLimite { get; set; }

        public int UsuarioId { get; set; }
        public Pessoa Usuario { get; set; }
    }

    public enum Sexo{
        Masculino,
        Feminino,
        Outros
    }
}