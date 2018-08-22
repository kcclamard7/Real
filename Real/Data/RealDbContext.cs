using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Real.Models;

namespace Real.Data
{
    public class RealDbContext : DbContext
    {
        public RealDbContext( DbContextOptions<RealDbContext>  options ) :base(options)
        {
                
        }
        public DbSet<Ville> Ville { get; set; }
        public DbSet<AgenceMere> AgenceMere { get; set; }
        


    }
}
