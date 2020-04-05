using Komis.Models;
using Microsoft.AspNetCore.Mvc;

namespace Komis.Controllers
{
    public class OpiniaController : Controller
    {
        private readonly IOpiniaRepository _opiniaRepository;

        public OpiniaController(IOpiniaRepository opiniaRepository)
        {
            _opiniaRepository = opiniaRepository;
        }

        [HttpGet]
        public IActionResult Index()                                    //akcja wyświetlenia formularza
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Opinia opinia)                       //akcja wciśnięcia przycisku
        {
            _opiniaRepository.DodajOpinie(opinia);

            return RedirectToAction("OpiniaWyslana");
            
        }

        public IActionResult OpiniaWyslana()                                    
        {
            return View();
        }
    }
}