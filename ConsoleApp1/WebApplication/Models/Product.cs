using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Product
    {
        [Display(Name="Nazwa produktu: ")]
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
