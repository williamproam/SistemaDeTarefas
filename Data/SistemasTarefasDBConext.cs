using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Data
{
    public class SistemasTarefasDBConext : DbContext
    {
        public SistemasTarefasDBConext(DbContextOptions<SistemasTarefasDBConext> options)
            :base(options)
        { 
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
