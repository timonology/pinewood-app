
namespace PinewoodAssessment.Application.Features.CreateUser;

public sealed class CreateUserResponse
{
    public Guid Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
}
