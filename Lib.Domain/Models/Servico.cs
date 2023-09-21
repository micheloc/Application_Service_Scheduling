using System.Text.Json.Serialization;

namespace Lib.Domain.Models;

public class Servico
{
    public Servico()
    {
        objID = Guid.NewGuid();
    }
    public Guid objID { get; set; }
    public string Descricao { get; set; }
    public string Sub_Descricao { get; set; }
    public string Tp_Servico { get; set; }
    public TimeSpan TempoServico { get; set; }
    public decimal Valor_Servico { get; set; }
    public byte[] imagem { get; set; }
    public string extension { get; set; }

    public virtual ICollection<Contrato_Servico> Contrato_Servico { get; set; }
}
