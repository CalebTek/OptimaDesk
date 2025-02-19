using Microsoft.AspNetCore.Authorization;

namespace OptimaDesk.Common
{
    public static class Policies
    {
        public const string Admin = "Admin";
        public const string SuperAdmin = "SuperAdmin";
        public const string StationManager = "StationManager";

        public static AuthorizationPolicy AdminPolicy()
        {
            return new AuthorizationPolicyBuilder().RequireAuthenticatedUser().RequireRole(Admin).Build();
        }

        public static AuthorizationPolicy SuperAdminPolicy()
        {
            return new AuthorizationPolicyBuilder().RequireAuthenticatedUser().RequireRole(SuperAdmin).Build();
        }

        public static AuthorizationPolicy StationManagerPolicy()
        {
            return new AuthorizationPolicyBuilder().RequireAuthenticatedUser().RequireRole(StationManager).Build();
        }
    }
}
