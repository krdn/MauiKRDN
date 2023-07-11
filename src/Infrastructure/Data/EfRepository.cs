using Ardalis.Specification.EntityFrameworkCore;
using Krdn.Maui.ApplicationCore.Interfaces;

namespace Krdn.Maui.Infrastructure.Data;
public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
{
    public EfRepository(CatalogContext dbContext) : base(dbContext)
    {
    }
}
