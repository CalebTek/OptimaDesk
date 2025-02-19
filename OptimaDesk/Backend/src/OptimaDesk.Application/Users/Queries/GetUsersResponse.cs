using AutoMapper;
using OptimaDesk.Common.Enums;
using OptimaDesk.Common.Mappings;
using OptimaDesk.Domain.Users;

namespace OptimaDesk.Application.Users.Queries
{
    public class GetUsersResponse : IMapFrom<AppUser>
    {
        public string? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Gender Gender { get; set; }
        public bool IsActive { get; set; }
        public string? Avatar { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string RefreshToken { get; set; } = string.Empty;
        public DateTime RefreshTokenExpiryTime { get; set; }
        public bool IsDeleted { get; set; } = false;
        public string? Password { get; set; }
        public Status Status { get; set; } = Status.Active;
        public DateTime LastLoginDate { get; set; }
        public string? Token { get; set; }
        public bool IsTokenValid { get; set; }
        public string? Otp { get; set; }
        public string? Email { get; internal set; }
        public string? UserName { get; internal set; }
        public string? PhoneNumber { get; internal set; }
        public UserType UserType { get; set; }
        public int LoginCount { get; set; }
        public string? Role { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AppUser, GetUsersResponse>().ReverseMap();
        }
    }
}
