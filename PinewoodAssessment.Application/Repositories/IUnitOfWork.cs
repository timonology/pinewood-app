using PinewoodAssessment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinewoodAssessment.Application.Repositories;

public interface IUnitOfWork : IDisposable
{
    //IBaseRepository<T> UserRespository<T>() where T : BaseEntity;
    Task Save(CancellationToken cancellationToken);
}
