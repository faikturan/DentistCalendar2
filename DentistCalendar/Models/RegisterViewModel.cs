﻿using System.ComponentModel.DataAnnotations;

namespace DentistCalendar.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz.")]
        [Display(Name="Kullanıcı Adınız:")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen adınızı giriniz.")]
        [Display(Name = "Adınız:")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadını giriniz.")]
        [Display(Name = "Soyadınız:")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz.")]
        [Display(Name = "Şifreniz:")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen emalinizi giriniz.")]
        [Display(Name = "Emailiniz:")]
        [EmailAddress(ErrorMessage="Lütfen email alanını kontrol ediniz.")]
        public string Email { get; set; }
 
        [Display(Name = "Randevu Rengi")]
        public string Color { get; set; }

        [Display(Name = "Doktorum")]
        public bool IsDentist { get; set; }

    }
}
