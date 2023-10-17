namespace Lib.Domain.Models;

/// <summary>
/// Essa classe é referente ao intervalos de datas. Ex: "Férias", "Feriados", "Datas Comemorativas", "Recesso". 
/// </summary>
public class DataIntervalos
{
    public DataIntervalos()
    {
        objID = Guid.NewGuid();
    }
    public Guid objID { get; set; }

    public string Data_Intervalo { get; set; }
    public string type_date { get; set; }
    public string descricao_data { get; set; }
}
