using PinewoodAssessment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinewoodAssessment.Application.Repositories;

public interface IUserRepository : IBaseRepository<User>
{
    //Task<List<User>> GetUsersByIdAsync(Guid id);
}
