using Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class ApiJogosContext : DbContext
    {
        public DbSet<JogoConsole> JogoConsole { get; set; }
        public DbSet<JogoDesktop> JogoDesktop { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Port=5434; Database=postgres; UserId=postgres; Password=1234");
        }
    }
}
