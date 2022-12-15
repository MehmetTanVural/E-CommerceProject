using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_Commerce.MvcWebUI.Models
{
    public class ShippingDetails
    {
        
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen bir adres tanımı giriniz")]
        public string AdresBasligi { get; set; }

        [Required(ErrorMessage = "Lütfen bir adres giriniz")]
        public string Adres { get; set; }

        [Required(ErrorMessage = "Lütfen bir şehir giriniz")]
        public string Sehir { get; set; }

        [Required(ErrorMessage = "Lütfen bir semt giriniz")]
        public string Semt { get; set; }

        [Required(ErrorMessage = "Lütfen mahalle giriniz")]
        public string Mahalle { get; set; }
        public string PostaKodu { get; set; }

    }
}