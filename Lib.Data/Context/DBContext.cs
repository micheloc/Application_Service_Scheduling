using Lib.Data.Context.Common;
using Lib.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Lib.Data.Context;

public class DBContext : BaseContext
{
    public DBContext(DbContextOptions<DBContext> options) : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();
    }
    public DbSet<DataIntervalos> DataIntervalos { get; set; }
    public DbSet<Cliente> Cliente { get; set; }
    public DbSet<ContatosAdicionais> ContatosAdicionais { get; set; }
    public DbSet<Contrato_Servico> Contato_Servico { get; set; }
    public DbSet<Empresa> Empresa { get; set; }
    public DbSet<Equipamentos> Equipamentos { get; set; }
    public DbSet<Servico> Servico { get; set; }
    public DbSet<HoursTimesAgenda> HoursTimesAgendas { get; set; }
    public DbSet<SlideLogin> SlideLogins { get; set; }
    public DbSet<TelaLogin> TelaLogin { get; set; }



}
