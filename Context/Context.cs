using Microsoft.EntityFrameworkCore;

namespace Euwinbadia_P1_Apl1.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
    }
}
