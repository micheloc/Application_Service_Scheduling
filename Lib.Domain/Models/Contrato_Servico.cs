namespace Lib.Domain.Models;
public class Contrato_Servico
{
    public Contrato_Servico()
    {
        objID = Guid.NewGuid();
    }
    public Guid objID { get; set; }
    public Guid IDServico { get; set; }
    public Guid IDEquipamento { get; set; }
    public Guid IDDeslocamento { get; set; }

    public string IDUsuario { get; set; }

    public DateTime Agendamento { get; set; }
    public DateTime HorarioFim { get; set; }
    public string DescricaoEquipamentos { get; set; }
    public string LinkBoleto { get; set; }
    public bool ConclusaoServico { get; set; }

    public virtual Usuario Usuario { get; set; }
    public virtual Servico Servico { get; set; }
    public virtual Equipamentos Equipamentos { get; set; }
    public virtual Deslocamento Deslocamento { get; set; }
}
