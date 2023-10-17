using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Lib.Data.Context.Interfaces;

public interface IDbIdentityContext
{
    DbSet<TEntity> Set<TEntity>() where TEntity : class;
    EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    ValidationResult SaveChanges();
    void Dispose();
}
