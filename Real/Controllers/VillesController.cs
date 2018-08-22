using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Real.Repositories;

namespace Real.Areas.Users.Controllers
{
    public class VillesController : Controller
    {
        private readonly IVilleRepository villeRepository;
        public VillesController(IVilleRepository villeRepository)
        {
            this.villeRepository = villeRepository;
        }

        public IActionResult Index() =>
            View(villeRepository.Villes.ToList());
    }
}