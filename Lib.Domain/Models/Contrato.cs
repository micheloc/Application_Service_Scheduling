namespace Lib.Domain.Models;
public class Contrato
{
    public Contrato()
    {
        objID = Guid.NewGuid();
    }

    public Guid objID { get; set; }
    public string Tipo_Contrato { get; set; }
    public byte[] Arquivo { get; set; }
    public string descricao { get; set; }
    public string titulo { get; set; }
    public string colorLinear1 { get; set; }
    public string colorLinear2 { get; set; }
    public string colorLinear3 { get; set; }
    public DateTime data1 { get; set; }
    public DateTime date2 { get; set; }
    public string colorOBS { get; set; }
    public string colorValor { get; set; }
    public string colorSub1 { get; set; }
    public string colorSub2 { get; set; }
    public string obs { get; set; }
    public string valor { get; set; }
    public string subTitulo1 { get; set; }
    public string subTitulo2 { get; set; }

    public virtual ICollection<Cliente_Contrato> Cliente_Contratos { get; set; }
}
