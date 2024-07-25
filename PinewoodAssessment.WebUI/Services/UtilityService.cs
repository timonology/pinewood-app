using PinewoodAssessment.WebUI.Models;

namespace PinewoodAssessment.WebUI.Services;

// this is just a simple api service to demonstrate getting data from api. nothing complex but hardcoded and didn't decouple it
// Reason for hardcoding is because of the time constraint. 

public class UtilityService
{
    private readonly HttpClient _httpClient;

    public UtilityService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<UserModel>> GetItemsAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<UserModel>>("https://localhost:7035/api/Users");
    }

    public async Task CreateItemAsync(CreateUserModel model)
    {
        await _httpClient.PostAsJsonAsync("https://localhost:7035/api/Users", model);
    }
}
