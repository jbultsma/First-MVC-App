using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Models
{
    public class Fish
    {
        [Required(ErrorMessage = "Error, name is required.")]
        [StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Error, Price is required.")]
        [Range (1,2000)]
        public float Price { get; set; }

        [Required(ErrorMessage = "Error, Quantity is required.")]
        [Range(1,100)]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Error, Description is required.")]
        [StringLength(500, MinimumLength = 1)]
        public string Description { get; set; }
    }
}
