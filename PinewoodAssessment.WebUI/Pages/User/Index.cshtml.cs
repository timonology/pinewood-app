using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PinewoodAssessment.WebUI.Models;
using PinewoodAssessment.WebUI.Services;

namespace PinewoodAssessment.WebUI.Pages.User;

public class IndexModel : PageModel
{
    private readonly UtilityService _utilityService;
    public IndexModel(UtilityService utilityService)
    {
        _utilityService = utilityService;
    }

    [BindProperty]
    public IEnumerable<UserModel> userModel { get; set; }
    public async Task OnGetAsync()
    {
        userModel = await _utilityService.GetItemsAsync();
    }
}
