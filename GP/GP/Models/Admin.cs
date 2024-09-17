﻿using System.ComponentModel.DataAnnotations;

namespace GP.Models
{
    public class Admin
    {
        public int Id { get; set; }

        [MaxLength(30)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Password { get; set; }
    }
}
