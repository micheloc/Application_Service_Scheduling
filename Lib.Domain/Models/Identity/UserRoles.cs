
namespace Lib.Domain.Models.Identity;
public class UserRoles : Microsoft.AspNetCore.Identity.IdentityUserRole<String>
{
    public UserRoles()
        :base()
    {
        
    }

    public string Discriminator { get; set; }

    public virtual Roles Roles { get; set; }
    public virtual Usuario Usuario { get; set; }
}
