using Microsoft.EntityFrameworkCore;

namespace BlazorServerModelo.Data
{
    public class ModeloDbContext : DbContext
    {
        public ModeloDbContext(DbContextOptions<ModeloDbContext> options) : base(options) 
        {

        }

        public ModeloDbContext() : base() 
        {

        }

        public DbSet<AgendaContatos> AgendaContatos { get; set; }

    }
}
