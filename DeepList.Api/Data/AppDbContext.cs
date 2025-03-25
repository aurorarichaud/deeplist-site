using Microsoft.EntityFrameworkCore;
using DeepList.Api.Models;

namespace DeepList.Api.Data {
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }

        // Foreign Key do Models Usuario.cs ao Tarefa.cs
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Tarefa>()
                .HasOne(t => t.Responsavel)         // Tarefa tem um responsavel
                .WithMany(u => u.Tarefas)           // Um usuario pode ter varias tarefas
                .HasForeignKey(t => t.UsuarioId)    // Foreign Key
                .OnDelete(DeleteBehavior.Cascade);  // CASCADE !! YEY
            base.OnModelCreating(modelBuilder);
        }
    }
}