using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace oSport.Models
{
    public class League
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("LeagueAdmin")]
        public int LeagueAdminId { get; set; }
        public LeagueAdmin LeagueAdmin { get; set; }

        [ForeignKey("Sport")]
        public int SportId { get; set; }
        public Sport Sport { get; set; }

        [Required]
        [Display(Name = "League Name")]
        public string LeagueName { get; set; }

        [Required]
        [Display(Name = "Team Capacity")]
        public int TeamCapacity { get; set; }

        
    }
}
