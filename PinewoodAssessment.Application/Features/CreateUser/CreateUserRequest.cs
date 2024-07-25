using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinewoodAssessment.Application.Features.CreateUser;

public sealed record CreateUserRequest(string FirstName, string LastName, string Email) : IRequest<CreateUserResponse>;
