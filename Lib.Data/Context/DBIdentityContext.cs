using Lib.Data.Context.Common;
using Lib.Domain.Models.Identity;
using Microsoft.EntityFrameworkCore;

namespace Lib.Data.Context;
public class DBIdentityContext : BaseContextIdentity
{
    public DBIdentityContext(DbContextOptions<DBIdentityContext> options) : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();
    }

    ////TABELAS ASP.NET IDENTITY
    public DbSet<Usuario> Usuario { get; set; }
    public DbSet<Roles> Roles { get; set; }
    public DbSet<UserRoles> UserRoles { get; set; }
    public DbSet<UserClaims> UserClaims { get; set; }
    public DbSet<RoleClaims> RoleClaims { get; set; }
    public DbSet<UserLogins> UserLogins { get; set; }
    public DbSet<UserTokens> UserTokens { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
