using Lib.Domain.Models.Identity;
namespace Lib.Domain.Models;
public class Cliente
{
    public Cliente()
    {
        objID = Guid.NewGuid();
    }
    public Guid objID { get; set; }
    public string Nome_Completo { get; set; }
    public string Telefone { get; set; }
    public string Celular { get; set; }
    public string RG { get; set; }
    public string IE { get; set; }
    public bool Tipo_Registro { get; set; }
    public bool Contratado { get; set; }
    public string Registro { get; set; }
    public string Empresa { get; set; }
    public string CEP { get; set; }
    public string Rua { get; set; }
    public int Numero { get; set; }
    public string Complemento { get; set; }
    public string Cidade { get; set; }
    public string Bairro { get; set; }
    public string Informacoes_Adicionais { get; set; }
    public bool Ativo { get; set; }
    public virtual ICollection<Cliente_Contrato> Cliente_Contratos { get; set; }
    public virtual ICollection<Equipamentos> Equipamentos { get; set; }
    public virtual ICollection<Usuario> Usuario { get; set; }
}