﻿using System.ComponentModel.DataAnnotations;

namespace Lesson11MvcAuth.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [MinLength(5)]
        public string Login { get; set; }

        [Required]
        [MinLength(5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [MinLength(5)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
