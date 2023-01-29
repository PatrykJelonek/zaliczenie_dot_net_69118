using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace zaliczenie_69118.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Display(Name = "Brewing Method")]
        public string BrewingMethod { get; set; } = String.Empty;

        [Display(Name = "Grammage")]
        public string Grammage { get; set; } = String.Empty;

        [Display(Name = "Fullname")]
        public string FullName { get; set; } = String.Empty;

        [Display(Name = "Address")]
        public string Address { get; set; } = String.Empty;

        [Display(Name = "Email")]
        public string Email { get; set; } = String.Empty;

        [Display(Name = "Price")]
        public decimal Price { get; set; } = 0.0M;

        [Display(Name = "Ordered At")]
        public DateTime Date { get; set; }

        [Display(Name = "Status")]
        public string Status { get; set; } = String.Empty;
    }
}

