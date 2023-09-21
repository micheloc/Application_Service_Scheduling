namespace Lib.Domain.Models;
public class Cliente_Contrato
{
    public Cliente_Contrato()
    {
        objID = Guid.NewGuid();
    }
    public Guid objID { get; set; }
    public Guid IDContrato { get; set; }
    public Guid IDCliente { get; set; }
    public bool Autorizado { get; set; }
    public string RazaoSocial { get; set; }
    public string cnpj_cpf { get; set; }
    public string email { get; set; }
    public string telefone { get; set; }
    public bool nf { get; set; }
    public int pagamento { get; set; }
    public int qtd_computadores { get; set; }
    public string nome_computadores { get; set; }
    public bool server_contrato { get; set; }
    public bool firewall_contrato { get; set; }
    public byte[] CopiaArquivo { get; set; }

    public virtual Cliente Cliente { get; set; }
    public virtual Contrato Contrato { get; set; }
}