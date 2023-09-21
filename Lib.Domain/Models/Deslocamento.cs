namespace Lib.Domain.Models;
public class Deslocamento
{
    public Guid objID { get; set; }
    public string Localidade { get; set; }
    public decimal Custo { get; set; }
    public virtual ICollection<Contrato_Servico> Contrato_Servico { get; set; }
}
