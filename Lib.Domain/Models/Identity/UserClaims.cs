using Microsoft.AspNetCore.Identity;

namespace Lib.Domain.Models.Identity;
public class UserClaims : IdentityUserClaim<string>
{
    public string Discriminator { get; set; }
    public virtual Usuario Usuario { get; set; }
}
