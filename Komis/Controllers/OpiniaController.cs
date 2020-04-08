using Komis.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Komis.Controllers
{
    [Authorize]
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
            if (ModelState.IsValid)
            {
               _opiniaRepository.DodajOpinie(opinia);
                return RedirectToAction("OpiniaWyslana");
            }
            else
            {
                return View(opinia);
            }
            
        }

        public IActionResult OpiniaWyslana()                                    
        {
            return View();
        }
    }
}