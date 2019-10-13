using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace assessment2.Models
{
    public partial class Registration
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }
        public string DisplayName { get; set; }
        [Required(ErrorMessage = "Please enter your password.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please enter your Email.")]
        public string Email { get; set; }
        public string Status { get; set; }
        public string Role { get; set; }
        public string ProfilePicture { get; set; }
        public DateTime? RegisteredDate { get; set; }
    }
}
