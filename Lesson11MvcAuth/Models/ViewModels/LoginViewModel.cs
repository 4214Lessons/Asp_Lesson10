﻿using System.ComponentModel.DataAnnotations;

namespace Lesson11MvcAuth.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [MinLength(5)]
        public string Login { get; set; }
        [Required]
        [MinLength(5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
