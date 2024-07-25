using AutoMapper;
using PinewoodAssessment.Domain.Entities;

namespace PinewoodAssessment.Application.Features.GetAllUser;

public class GetAllUserMapper : Profile
{
    public GetAllUserMapper()
    {
        CreateMap<User, GetAllUserResponse>();
    }
}
