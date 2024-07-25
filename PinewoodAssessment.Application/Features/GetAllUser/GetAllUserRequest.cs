using MediatR;

namespace PinewoodAssessment.Application.Features.GetAllUser;

public sealed record GetAllUserRequest : IRequest<List<GetAllUserResponse>>;
