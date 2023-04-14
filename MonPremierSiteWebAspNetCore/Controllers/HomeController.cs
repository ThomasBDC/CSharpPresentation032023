using Microsoft.AspNetCore.Mvc;
using MonPremierSiteWebAspNetCore.Models;
using NameGenerator.Generators;
using System.Diagnostics;

namespace MonPremierSiteWebAspNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult GamerList()
        {
            //-> A executer
            //Je veux récupérer mes gamer depuis mon model (qui va utiliser la librairie qu'on a installée).
            List<Gamer> allGamers = new List<Gamer>();
            for (int i = 0; i < 200; i++)
            {
                RealNameGenerator Generator = new RealNameGenerator();
                GamerTagGenerator GeneratorGT = new GamerTagGenerator();
                var monGamer = new Gamer(i, Generator.Generate(), GeneratorGT.Generate());
                allGamers.Add(monGamer);
            }
            //La liste allGamers contient 200 gamers

            var vm = new GamersViewModel(allGamers);

            //Je veux envoyer ce model à la vue
            return View("GamerList", vm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}