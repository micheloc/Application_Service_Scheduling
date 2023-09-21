using Microsoft.AspNetCore.Identity;

namespace Lib.Domain.Models.Identity;
public class UserLogins : IdentityUserLogin<string>
{
    public UserLogins()
        : base()
    {
        
    }
}
