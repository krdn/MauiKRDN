using Ardalis.Specification;

namespace Krdn.Maui.ApplicationCore.Interfaces;
public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
{
}
