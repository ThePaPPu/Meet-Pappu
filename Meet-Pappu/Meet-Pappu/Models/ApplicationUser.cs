using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;

namespace Meet_Pappu.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        //relation
        public List<Post>? Posts { get; set; }
    }
}
