using AutoMapper;
using MediatR;
using PinewoodAssessment.Application.Repositories;
using PinewoodAssessment.Domain.Entities;
using System.Threading;

namespace PinewoodAssessment.Application.Features.GetAllUser;

public class GetAllUserHandler : IRequestHandler<GetAllUserRequest, List<GetAllUserResponse>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IUserRepository _userRepository;

    public GetAllUserHandler(IUnitOfWork unitOfWork, IMapper mapper, IUserRepository userRepository)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _userRepository = userRepository;
    }

    public async Task<List<GetAllUserResponse>> Handle(GetAllUserRequest request, CancellationToken cancellation)
    {
        var users = await _userRepository.GetAll(cancellation);
        return _mapper.Map<List<GetAllUserResponse>>(users);
    }
}
