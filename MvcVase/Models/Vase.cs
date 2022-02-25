using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcVase.Models
{
    public class Vase
    {
       
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set;  }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string Type { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Material { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Shape { get; set; }
        public bool Antique { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }  // Added New Field for the rating

    }
}
