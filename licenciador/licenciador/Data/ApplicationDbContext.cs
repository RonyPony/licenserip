using licenciador.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace licenciador.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Token> Tokens { get; set; }
    }
}
