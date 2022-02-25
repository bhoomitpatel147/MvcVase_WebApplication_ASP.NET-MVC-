using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcVase.Models
{
    public class VaseMaterialViewModel
    {
        public List<Vase> Vases { get; set; }  // List of vases
        public SelectList Materials { get; set; }   // SelectList contains all the Materials 
        public string VaseMaterial { get; set; }  // VaseMaterial which contain selected material 
        public string SearchString { get; set; }  // SearchString contain the text users enter in the search text box
    }
}
