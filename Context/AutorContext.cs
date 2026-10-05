using Euwinbadia_P1_Apl1.Models;
using Microsoft.EntityFrameworkCore;

namespace Euwinbadia_P1_Apl1.Context
{
    public class AutorContext : DbContext
    {
        public AutorContext(DbContextOptions<AutorContext> options) : base(options)
        {
        }
        public DbSet<Autores> Autor { get; set; }
    }
}
