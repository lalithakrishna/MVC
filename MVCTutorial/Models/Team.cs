﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCTutorial.Models
{
    [Table("Teams")]
    public class Team
    {
        [Key]
        public string TeamName { get; set; }
        public List<Player> players { get; set; }
    }
}