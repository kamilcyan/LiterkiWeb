using LiterkiWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace LiterkiWeb.Controllers
{
    public class LiterkiController : Controller
    {
        public IActionResult GetLetters()
        {
            List<Literki> literki = new List<Literki>();
            literki.Add(new Literki()
            {
                Id = 1,
                Nazwa = "A",
                PictureUrl = "/images/aduze.png"
            });
            literki.Add(new Literki()
            {
                Id = 2,
                Nazwa = "B",
                PictureUrl = "/images/bduze.png"
            });
            literki.Add(new Literki()
            {
                Id = 3,
                Nazwa = "C",
                PictureUrl = "/images/cduze.png"
            });
            return View(literki);
        }
    }
}
