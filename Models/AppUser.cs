using Microsoft.AspNetCore.Identity;

namespace apbdtask10_v2.Models
{
    public class AppUser : IdentityUser
    {
        //Id
        //Email
        //PasswordHash
        //Role
        //CreatedAt

        public DateTime CreatedAt { get; set; }
    }
}