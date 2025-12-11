using Relations.Integration.Services;

public class Program
{
    public static async Task Main(string[] args)
    {
        HotelBookingIntegration hotel = new HotelBookingIntegration();

        var allHotel = await hotel.GetAllHotels();

        foreach (var item in allHotel)
        {
            Console.WriteLine(item);
        }



    }
}