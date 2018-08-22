using Real.Models;
using Real.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Real.Repositories
{
    public class VilleRepository : IVilleRepository
    {

        // we inject the DbContext so we can use it 
        private readonly RealDbContext context;

        public VilleRepository(RealDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Ville> Villes => context.Ville;

       
    }
}
