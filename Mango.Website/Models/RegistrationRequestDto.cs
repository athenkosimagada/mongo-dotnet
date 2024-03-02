﻿using System.ComponentModel.DataAnnotations;

namespace Mango.Website.Models
{
    public class RegistrationRequestDto
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        public string? Role { get; set; } = string.Empty;
    }
}
