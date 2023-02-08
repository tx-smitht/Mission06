﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DateMe.Models
{
    public class ApplicationResponse
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public byte Age { get; set; }

        [Required]
        public string Phone { get; set; }
        public string Major { get; set; }

        [Required]
        public bool CreeperStalker { get; set; }
    }
}
