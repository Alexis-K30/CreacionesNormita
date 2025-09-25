using System.Diagnostics;
using CreacionesNormita.Models;
using Microsoft.AspNetCore.Mvc;

namespace CreacionesNormita.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static List<DressViewModel> _vestidos;

        static HomeController()
        {
            _vestidos = new List<DressViewModel>
            {
                new DressViewModel { Id = 1, Name = "Vestido de Novia Clásico", Description = "Un vestido elegante para tu día especial, con encaje delicado.", Price = 450.00m, ImageUrl = "/images/vestido1.jpg" },
                new DressViewModel { Id = 2, Name = "Vestido de Fiesta Rojo", Description = "Vestido vibrante ideal para fiestas, con corte sirena.", Price = 250.00m, ImageUrl = "/images/vestido1.jpg" },
                new DressViewModel { Id = 3, Name = "Vestido Casual Azul", Description = "Vestido ligero y cómodo para uso diario, en algodón orgánico.", Price = 120.00m, ImageUrl = "/images/vestido1.jpg" },
                new DressViewModel { Id = 4, Name = "Vestido 1 Elegante", Description = "Descripción detallada del vestido 1. Hecho con materiales de alta calidad.", Price = 396.92m, ImageUrl = "/images/vestido1.jpg" },
                new DressViewModel { Id = 5, Name = "Vestido 2 Elegante", Description = "Descripción detallada del vestido 2. Hecho con materiales de alta calidad.", Price = 383.10m, ImageUrl = "/images/vestido1.jpg" },
                new DressViewModel { Id = 6, Name = "Vestido 3 Elegante", Description = "Descripción detallada del vestido 3. Hecho con materiales de alta calidad.", Price = 182.03m, ImageUrl = "/images/vestido1.jpg" },
                new DressViewModel { Id = 7, Name = "Vestido 4 Elegante", Description = "Descripción detallada del vestido 4. Hecho con materiales de alta calidad.", Price = 294.48m, ImageUrl = "/images/vestido1.jpg" },
                new DressViewModel { Id = 8, Name = "Vestido 5 Elegante", Description = "Descripción detallada del vestido 5. Hecho con materiales de alta calidad.", Price = 222.22m, ImageUrl = "/images/vestido1.jpg" },
                new DressViewModel { Id = 9, Name = "Vestido 6 Elegante", Description = "Descripción detallada del vestido 6. Hecho con materiales de alta calidad.", Price = 110.83m, ImageUrl = "/images/vestido1.jpg" },
                new DressViewModel { Id = 10, Name = "Vestido 7 Elegante", Description = "Descripción detallada del vestido 7. Hecho con materiales de alta calidad.", Price = 151.31m, ImageUrl = "/images/vestido1.jpg" },
                new DressViewModel { Id = 11, Name = "Vestido 8 Elegante", Description = "Descripción detallada del vestido 8. Hecho con materiales de alta calidad.", Price = 159.64m, ImageUrl = "/images/vestido1.jpg" },
                new DressViewModel { Id = 12, Name = "Vestido 9 Elegante", Description = "Descripción detallada del vestido 9. Hecho con materiales de alta calidad.", Price = 337.51m, ImageUrl = "/images/vestido1.jpg" },
                new DressViewModel { Id = 13, Name = "Vestido 10 Elegante", Description = "Descripción detallada del vestido 10. Hecho con materiales de alta calidad.", Price = 100.82m, ImageUrl = "/images/vestido1.jpg" }
            };
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(_vestidos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //vista admin (ejemplo no funcional)
        public IActionResult Admin()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Details(int id)
        {
            var vestido = _vestidos.FirstOrDefault(v => v.Id == id);
            if (vestido == null)
            {
                return NotFound();
            }
            return View(vestido);
        }
    }
}
