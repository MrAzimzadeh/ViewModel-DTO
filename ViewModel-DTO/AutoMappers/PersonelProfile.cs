using AutoMapper;
using ViewModel_DTO.Models;
using ViewModel_DTO.Models.ViewModels;

namespace ViewModel_DTO.AutoMappers
{
    public class PersonelProfile :Profile
    {
        public PersonelProfile()
        {
            CreateMap<Personel, PersonelCreateVM>(); // personeli vm e donsuturur 
            CreateMap<PersonelCreateVM, Personel>(); //  vm i   personele donsuturur 
        }
    }
}
