using System.Text.Json.Serialization;

namespace Lib.Domain.Models;
public class Equipamentos
{
    public Equipamentos()
    {
        objID = Guid.NewGuid();
    }
    public Guid objID { get; set; }
    public Guid? IDCliente { get; set; }
    public string Nome { get; set; }
    public string Modelo { get; set; }
    public string Marca { get; set; }
    public string Conexao { get; set; }
    public string IP { get; set; }
    public string NS { get; set; }
    public bool Contratado { get; set; }
    public string Disco { get; set; }
    public string Processador { get; set; }
    public string Memoria { get; set; }
    public bool Ativo { get; set; }
    public bool Impressora { get; set; }
    public string Observacoes { get; set; }

    public virtual ICollection<Contrato_Servico> Contrato_Servico { get; set; }
    public virtual Cliente Cliente { get; set; }
}
