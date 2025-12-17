using Microsoft.AspNetCore.Mvc;
using mvc_bangun_datar.Models;
using mvc_bangun_datar.ViewModels;

namespace mvc_bangun_datar.Controllers
{
    public class BangunDatarController : Controller
    {
        public IActionResult Persegi(double sisi)
        {
            var persegi = new Persegi { Sisi = sisi };

            var vm = new BangunDatarViewModel
            {
                NamaBangun = "Persegi",
                Luas = persegi.HitungLuas()
            };

            return View(vm);
        }

        public IActionResult Lingkaran(double r)
        {
            var lingkaran = new Lingkaran { JariJari = r };

            var vm = new BangunDatarViewModel
            {
                NamaBangun = "Lingkaran",
                Luas = lingkaran.HitungLuas()
            };

            return View(vm);
        }
    }
}
