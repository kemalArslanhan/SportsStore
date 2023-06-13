﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SportsStore.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }
        [Required(ErrorMessage ="Please enter a name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the first address line")]
        [Display(Name="Adresse Line 1")]
        public string Line1 { get; set; }
        [Display(Name="Adresse Line 2")]
        public string Line2 { get; set; }
        [Display(Name="Adresse Line §")]
        public string Line3 { get; set; }
        [Required(ErrorMessage = "Please enter your city name")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter your state name")]
        public string State{ get; set; }
        public string Zip { get; set; }
        [Required(ErrorMessage = "Please enter your Country name")]
        public string Country { get; set; }
        public bool GiftWrap { get; set; }

    }
}
