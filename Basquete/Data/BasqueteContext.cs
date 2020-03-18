using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Basquete.Models;

namespace Basquete.Data
{
    public class BasqueteContext : DbContext
    {
        public BasqueteContext (DbContextOptions<BasqueteContext> options)
            : base(options)
        {
        }

        public DbSet<Basquete.Models.Ponto> Ponto { get; set; }
    }
}
