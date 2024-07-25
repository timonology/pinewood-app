
using PinewoodAssessment.Domain.Common;

namespace PinewoodAssessment.Application.Repositories;

public interface IBaseRepository<T> where T : BaseEntity
{
    IQueryable<T> Entities { get; }

    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task<T> Get(Guid id);
    Task<List<T>> GetAll(CancellationToken cancellationToken);
}
