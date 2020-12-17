using Microsoft.EntityFrameworkCore;
using toDosMvc.Models;

namespace toDosMvc.Dados
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ToDo> ToDos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>().HasKey(p => p.Id);
            modelBuilder.Entity<Usuario>().HasMany(p => p.ToDos).WithOne(t => t.Usuario).HasForeignKey(p => p.UsuarioId).IsRequired();

            modelBuilder.Entity<ToDo>().HasKey(t => t.Id);
            modelBuilder.Entity<ToDo>().HasOne(t => t.Usuario);
        }
    }
}
