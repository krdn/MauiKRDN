using Ardalis.Specification;

namespace Krdn.Maui.ApplicationCore.Interfaces;
public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}