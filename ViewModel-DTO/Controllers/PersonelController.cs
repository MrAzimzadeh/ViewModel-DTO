using Microsoft.AspNetCore.Mvc;
using ViewModel_DTO.Models;
using ViewModel_DTO.Models.ViewModels;

namespace ViewModel_DTO.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(PersonelCreateVM createVm)
        {
            // ....
            return View();
        }

        public IActionResult Listele()
        {
            List<PersonelListeVM> personels = new List<Personel>()
            {
                new Personel { Name = "a", surName = "B" },
                new Personel { Name = "a1", surName = "B" },
                new Personel { Name = "a2", surName = "B" },
                new Personel { Name = "a3", surName = "B" },
                new Personel { Name = "a4", surName = "B" },
                new Personel { Name = "a5", surName = "B" },
            }.Select(p => new PersonelListeVM
            {
                Name = p.Name,
                Pozisyon = p.Pozisyon,
                surName = p.surName
            }).ToList();
            return View(personels);
        }
    }
}
