using System.Data.Entity.Infrastructure;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Lib.Data.Context.Common;

internal class BaseContext
{
    public AppDbContext(DbContextOptions<DBContext> options) : base(options)
    {

    }

    public DbSet<TEntity> Set<TEntity>() where TEntity : class
    {
        return base.Set<TEntity>();
    }

    public EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
    {
        return base.Entry(entity);
    }

    public ValidationResult SaveChanges()
    {
        var result = new ValidationResult();
        try
        {
            base.SaveChanges();
        }
        catch (DbUpdateException ex)
        {
            // Tratar exceções do Entity Framework, se necessário
            result.Errors.Add(new ValidationFailure("DbUpdateException", ex.Message));
        }
        catch (Exception ex)
        {
            result.Errors.Add(new ValidationFailure(ex.GetType().Name, ex.Message));
            if (ex.InnerException != null)
            {
                result.Errors.Add(new ValidationFailure(ex.InnerException.GetType().Name, ex.InnerException.Message));
            }
        }

        return result;
    }

    public void Dispose()
    {
        base.Dispose();
    }

}
