using Lib.Domain.Models.Identity;

namespace Lib.Domain.Models.Identity;
public class Roles : Microsoft.AspNetCore.Identity.IdentityRole<String>
{
    public Roles()
    : base()
    {

    }
    public virtual ICollection<RoleClaims> RoleClaims { get; set; } 
    public virtual ICollection<UserRoles> UserRoles { get; set; }
}
