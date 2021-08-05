using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MissingPersonApi.Models
{
    public class MissingReport
    {
        public int id { get; set; }

        [Display(Name = "Name of Person")]
        public string Ctitle { get; set; }

        [Display(Name = "Address Name")]
        public string CAddress { get; set; }

        [Display(Name = "Missing Date")]
        public DateTime Mdate { get; set; }

        [Display(Name = "Details")]
        public string Cdetail { get; set; }

        

    }
}
