using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PinewoodAssessment.WebUI.Models;
using PinewoodAssessment.WebUI.Services;

namespace PinewoodAssessment.WebUI.Pages.User;

public class CreateModel : PageModel
{
    private readonly UtilityService _utilityService;

    [BindProperty]
    public CreateUserModel createUserModel { get; set; }
    public CreateModel(UtilityService utilityService)
    {
        _utilityService = utilityService;
    }

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (ModelState.IsValid)
        {
            var user = _utilityService.CreateItemAsync(createUserModel);
            // no validations

            await _utilityService.GetItemsAsync();
            return RedirectToPage("/User/Index");
            


        }
        return Page();
    }


}
