using Microsoft.AspNetCore.Identity;
using OptimaDesk.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace OptimaDesk.Domain.Users
{
    /// <summary>
    /// Represents an application user.
    /// </summary>
    public class AppUser : IdentityUser
    {
        // Personal Details
        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        // Calculated Property
        public string FullName => $"{FirstName} {LastName}";

        // Custom User Properties
        public UserType UserType { get; set; }
        public Status Status { get; set; }
        public Gender Gender { get; set; }

        // Optional Profile Data
        public string? Avatar { get; set; }

        // Token Management
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }

        // Security Properties for OTP (One Time Password)
        public string? Token { get; set; }
        public string? Otp { get; set; }
        public DateTime? OtpExpiration { get; set; }

        // Login Tracking
        public int LoginCount { get; set; } = 0;

        // Metadata for auditing
        public string? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
         public int? Version { get; set; }
    }
}
