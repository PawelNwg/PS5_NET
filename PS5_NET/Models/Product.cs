using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace PS5_NET.Models
{
    public class Product
    {
        [Display(Name = "Id")]      
        public int id { get; set; }

        [Display(Name = "Nazwa")]
        [Required(ErrorMessage = "Nazwa jest obowiązkowa")]
        public string name { get; set; }

        [Display(Name = "Cena")]
        [Required(ErrorMessage = "Cena jest obowiązkowa")]
        [Range(0,99999999)]
        

        public decimal price { get; set; }



        public static List<Product> GetProducts()
        {
            Product pilka = new Product
            {
                id = 1,
                name = "Piłka nożna",
                price = 25.30M
            };
            Product narty = new Product { id = 2, name = "Narty", price = 150.39M };
            Product rakieta = new Product { id = 3, name = "Rakieta ", price = 111.10M };
            return new List<Product> { pilka, narty, rakieta };
        }
    }
}