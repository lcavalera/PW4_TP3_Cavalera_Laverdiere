using Microsoft.AspNetCore.Identity;

namespace IdentityServerAspNetIdentity.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public bool IsAdmin { get; set; } = false;
        public bool IsManager { get; set; } = false ;
    } 
}
