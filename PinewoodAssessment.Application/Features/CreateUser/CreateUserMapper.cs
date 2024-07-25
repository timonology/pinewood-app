using AutoMapper;
using PinewoodAssessment.Domain.Entities;

namespace PinewoodAssessment.Application.Features.CreateUser;

public class CreateUserMapper : Profile
{
    public CreateUserMapper() 
    {
        CreateMap<CreateUserRequest, User>();
        CreateMap<User, CreateUserResponse>();
    }
}
