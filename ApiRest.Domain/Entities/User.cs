using System;
using System.ComponentModel.DataAnnotations;

namespace Takever.Domain
{
    public class User
    {
        public long Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Name { get; set; }
        public string Token { get; set; }
    }
}
