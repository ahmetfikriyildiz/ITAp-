﻿using System.ComponentModel.DataAnnotations;

namespace ITApı.ViewModel
{
    public class RegisterViewModel
    {
        
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
