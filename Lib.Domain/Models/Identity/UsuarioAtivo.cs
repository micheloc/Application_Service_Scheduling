namespace Lib.Domain.Models.Identity;
public class UsuarioAtivo 
{
    public UsuarioAtivo(){ 
        objID = Guid.NewGuid(); 
    }

    [System.ComponentModel.DataAnnotations.Key]
    public Guid objID { get; set; }
    public Guid IDEmpresa { get; set; }
    public String IDUsuario { get; set; }
    public Boolean Ativo { get; set; }
    public Boolean Conectado { get; set; }

    public virtual Empresa Empresa { get; set; }
    public virtual Usuario Usuario { get; set; }
}

