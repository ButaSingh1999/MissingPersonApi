using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MissingPersonApi.Models
{
    public class Message
    {
        //Message id
        public int Id { get; set; }

        //Mesage text
        [Display(Name = "Name ")]
        public string Name { get; set; }

        //Message sender
        [Display(Name = "Message ")]
        public string Msg{ get; set; }

        //Message time
        [Display(Name = "Time ")]
        public DateTime time { get; set; }

    }
}
