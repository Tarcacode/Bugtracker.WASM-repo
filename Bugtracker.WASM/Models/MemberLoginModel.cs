﻿using System.ComponentModel.DataAnnotations;

namespace Bugtracker.WASM.Models
{
    public class MemberLoginModel
    {
        [Required]
        public string Pseudo { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}