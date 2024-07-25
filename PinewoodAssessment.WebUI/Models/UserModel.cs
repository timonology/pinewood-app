using System.ComponentModel.DataAnnotations;

namespace PinewoodAssessment.WebUI.Models;

public class UserModel
{
    public Guid Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string Email { get; set; }
}
