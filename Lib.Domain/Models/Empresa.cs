using System.Text.Json.Serialization;
namespace Lib.Domain.Models;
public class Empresa
{
    public Empresa(){ objID = Guid.NewGuid(); }

    public Guid objID { get; set; }
    public string nome { get; set; }
    public string cnpj { get; set; }
    public string fone { get; set; }
    public string email { get; set; }
    public string site { get; set; }

    public virtual ICollection<Usuario> Usuario { get; set; }
}
