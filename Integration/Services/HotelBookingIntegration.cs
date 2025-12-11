using Relations.Integration.Models.HotelModel;
using System.Text.Json;

namespace Relations.Integration.Services;

public class HotelBookingIntegration
{
    private readonly HttpClient _httpClient;
    public HotelBookingIntegration()
    {
        _httpClient = new HttpClient();
    }

    public async Task<List<HotelModel>?> GetAllHotels()
    {
        var content = await _httpClient.GetStringAsync("https://hotelbooking.stepprojects.ge/api/Hotels/GetAll");
        return JsonSerializer.Deserialize<List<HotelModel>>(content);
    }
}
