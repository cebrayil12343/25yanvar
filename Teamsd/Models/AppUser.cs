using Microsoft.AspNetCore.Identity;

namespace Teamsd.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
    }
}
