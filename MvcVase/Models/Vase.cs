using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcVase.Models
{
    public class Vase
    {

        public int Id { get; set; }
        public string Name { get; set;  }
        public string Type { get; set; }
        public string Material { get; set; }
        public string Shape { get; set; }
        public bool Antique { get; set; }
    }
}
