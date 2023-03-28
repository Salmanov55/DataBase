using Microsoft.AspNetCore.Identity;

namespace BackendProject.Models
{
    public class AppUser:IdentityUser
    {
        public string Fullname { get; set; } = null!;
        public bool IsActive { get; set; }
      
    }
}
