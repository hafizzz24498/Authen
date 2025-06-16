using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Entities.Model
{
    public class Account : IdentityUser<Guid>
    {
        [Required, MaxLength(100)]
        public required string FirstName { get; set; }
        [Required, MaxLength(100)]
        public required string LastName { get; set; }
        public required DateTime DateOfBirth { get; set; }
        [MaxLength(500)]
        public string? Address { get; set; }
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        [ForeignKey("Role")]
        [Required]
        public Guid? RoleId { get; set; }

        public Role? Role { get; set; }
    }
    
}