using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Entityframeworkcodefirst.Models
{
    public class Team
    {
        [Key]
        [MaxLength(30)]
        public string TeamName { get; set; }
        public string Type { get; set; }
        public string province { get; set; }
        public string Country { get; set; }

        public List<Player> Player { get; set; }
    }
}