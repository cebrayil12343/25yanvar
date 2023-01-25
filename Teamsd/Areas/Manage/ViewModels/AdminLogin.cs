﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace Teamsd.Areas.Manage.ViewModels
{
    public class AdminLogin
    {
        [Required]
        [StringLength(maximumLength: 50)]
        public string UserName { get; set; }
        [Required]
        [StringLength(maximumLength: 50,MinimumLength =8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
