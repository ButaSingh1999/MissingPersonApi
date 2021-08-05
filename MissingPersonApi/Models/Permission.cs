using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MissingPersonApi.Models
{
    public class Permission
    {
        public int id { get; set; }

        [Display(Name = " User Name")]
        public string UName { get; set; }

        [Display(Name = " Password")]
        public string UPassword { get; set; }

    }
}
