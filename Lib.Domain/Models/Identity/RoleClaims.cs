using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Lib.Domain.Models.Identity;
public class RoleClaims : IdentityRoleClaim<string>
{
    [Key]
    public int Id { get; set; }


    public string RoleId { get; set; }
    public string ClaimType { get; set; }
    public string ClaimValue { get; set; }


    public virtual Roles Roles { get; set; }
}
