using System.ComponentModel.DataAnnotations;

namespace ViewModel_DTO.Models.ViewModels
{
    public class PersonelCreateVM
    {
        // dasinilacaq melumatlarin transferi var 
        [Required]
        public string Name { get; set; }
        [Required]
        public string surName { get; set; }
    }
}
