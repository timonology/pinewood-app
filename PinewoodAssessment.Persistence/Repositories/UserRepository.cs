using Microsoft.EntityFrameworkCore;
using PinewoodAssessment.Application.Repositories;
using PinewoodAssessment.Domain.Entities;
using PinewoodAssessment.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PinewoodAssessment.Persistence.Repositories;


public class UserRepository : BaseRepository<User>, IUserRepository
{
    private readonly IBaseRepository<User> _repository;

    public UserRepository(UserDbContext context) : base(context)
    {
    }
}

