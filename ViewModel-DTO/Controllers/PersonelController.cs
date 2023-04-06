using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ViewModel_DTO.Business;
using ViewModel_DTO.Models;
using ViewModel_DTO.Models.ViewModels;

namespace ViewModel_DTO.Controllers
{
    public class PersonelController : Controller
    {
        public IMapper Mapper { get; }

        public PersonelController(IMapper mapper)
        {
            Mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(PersonelCreateVM createVm)
        {
            #region Amelaus(manuel) donusturme
            /*
            Personel pesonel = new Personel()
            {
               Name = createVm.Name,
               surName = createVm.surName
            };
            */
            #endregion

            #region Implicit




            //Personel personel = createVm;
            //PersonelCreateVM vm = personel;
            #endregion

            #region Explicit
            //Personel p = (Personel)createVm;
            //PersonelCreateVM personel = (PersonelCreateVM)p;
            #endregion

            #region Reflection
            //Personel p = TypeConversion.Converion<PersonelCreateVM, Personel>(createVm);
            //PersonelListeVM personelListeVm = TypeConversion.Converion<Personel, PersonelListeVM>(new Personel
            //{
            //    Name = "Name112",
            //    surName = "surname 2121"
            //});
            #endregion

            #region  AoutoMapper

            Personel p = Mapper.Map<Personel>(createVm);
            PersonelCreateVM vm = Mapper.Map<PersonelCreateVM>(p);

            #endregion


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

        public IActionResult Get()
        {
            return View();
        }



    }

}
