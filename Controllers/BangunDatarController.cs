using Microsoft.AspNetCore.Mvc;
using mvc_bangun_datar.Models;
using mvc_bangun_datar.ViewModels;

namespace mvc_bangun_datar.Controllers
{
    public class BangunDatarController : Controller
    {
        // 1️⃣ GET: tampilkan form
        public IActionResult Index()
        {
            return View();
        }

        // 2️⃣ POST: terima data dari form
        [HttpPost]
        public IActionResult HitungPersegi(InputBangunDatarViewModel input)
        {
            
            var persegi = new Persegi
            {
                Sisi = input.Sisi
            };

            var vm = new BangunDatarViewModel
            {
                NamaBangun = "Persegi",
                Luas = persegi.HitungLuas()
            };

            return View("Hasil", vm);
        }
    }
}
