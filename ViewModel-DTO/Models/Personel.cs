using System.Diagnostics.CodeAnalysis;
using ViewModel_DTO.Models.ViewModels;

namespace ViewModel_DTO.Models
{
    //entity model 
    public class Personel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string surName { get; set; }
        public string Pozisyon { get; set; }
        public int Maas { get; set; }
        public bool MedeniHal { get; set; }


        #region Implicit(gizli , bilincsiz )

        //public static implicit operator PersonelCreateVM(Personel model)
        //{
        //    return new PersonelCreateVM
        //    {
        //        Name = model.Name,
        //        surName = model.surName
        //    };
        //}
        ////Tersine cevirme 
        //public static implicit operator Personel(PersonelCreateVM model)
        //{
        //    return new Personel
        //    {
        //        Name = model.Name,
        //        surName = model.surName
        //    };
        //}

        #endregion
        #region  Explicit(acik ,  bilincli )

        public static explicit operator PersonelCreateVM(Personel model)
        {
            return new PersonelCreateVM
            {
                Name = model.Name,
                surName = model.surName
            };
        }
        //Tersine cevirme 
        public static explicit operator Personel(PersonelCreateVM model)
        {
            return new Personel
            {
                Name = model.Name,
                surName = model.surName
            };
        }
        #endregion
    }
}
