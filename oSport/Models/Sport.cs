using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace oSport.Models
{
    public class Sport
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [Display(Name = "Sport")]
        public string Name { get; set; }
    }
}
