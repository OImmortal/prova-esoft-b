using FilaDeAtendimento.Models;
using Microsoft.EntityFrameworkCore;

namespace FilaDeAtendimento.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected AppDbContext()
        {
        }

        public DbSet<Senha> senha => Set<Senha>();

    }
}