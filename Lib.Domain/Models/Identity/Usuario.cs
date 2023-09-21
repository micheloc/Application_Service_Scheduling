namespace Lib.Domain.Models.Identity;

public class Usuario : Microsoft.AspNetCore.Identity.IdentityUser<String>
{
    public Usuario()
        : base()
    {
        Id = Guid.NewGuid().ToString();
    }

    public string NomeUsuario { get; set; }

    public virtual ICollection<UserRoles> UserRoles { get; set; }
    public virtual ICollection<UserClaims> UserClaims { get; set; }
    public virtual ICollection<UsuarioAtivo> UsuarioAtivo { get; set; }
}