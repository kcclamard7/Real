using Real.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Real.Repositories
{
    public interface IVilleRepository
    {
        IQueryable<Ville> Villes { get; }
    }
}
