using Relations.Models;
using Relations.Services;

public class Program
{
    public static void Main(string[] args)
    {

        AdminUserService userService = new AdminUserService();
        while (true)
        {
            HandleLoadMenu();
            var userChoice = int.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    HandleAddNewUser(userService);
                    break;
                case 2:
                    HandleGetAllUsers(userService);
                    break;
                case 3:
                    HandleSignIn(userService);
                    break;
                default:
                    Console.WriteLine("jerjerobit msgavsi funqcionali ar gvaqvs");
                    break;
            }
        }
    }

    public static void HandleSignIn(AdminUserService userService)
    {
        var users = userService.GetAllUsers();
        Console.WriteLine("Please enter Email");
        var email = Console.ReadLine();
        Console.WriteLine("Shemoiyvane Paroli");
        var password = Console.ReadLine();

        var IsMath = users.Any(x => x.Email == email && VerifyPassword(x.PasswordHashed, password));

        if (IsMath)
        {
            Console.WriteLine("Hello Hello");
        }
        else
        {
            Console.WriteLine("please create an account");
        }
    }

    public static void HandleLoadMenu()
    {
        Console.WriteLine("Airchie operacia");
        Console.WriteLine("1 - axali mommareblis damateba");
        Console.WriteLine("2 - yvela moxmareblis naxva.");
        Console.WriteLine("3 - Shesvla");
    }

    public static void HandleGetAllUsers(AdminUserService user)
    {
        var all = user.GetAllUsers();
        foreach (var item in all)
        {
            Console.WriteLine(item);
        }
    }

    public static void HandleAddNewUser(AdminUserService userService)
    {
        AdminUser CreatedUser = new AdminUser();
        Console.WriteLine("Shemoiyvane saxeli");
        CreatedUser.Name = Console.ReadLine();

        Console.WriteLine("Shemoiyvane Email");
        CreatedUser.Email = Console.ReadLine();

        Console.WriteLine("shemoiyvane telephonis nomeri");
        CreatedUser.PhoneNumber = Console.ReadLine();

        Console.WriteLine("Shemoiyvane paroli");
        CreatedUser.PasswordHashed = EncryptPassword(Console.ReadLine());

        userService.AddNewUser(CreatedUser);
    }

    public static string EncryptPassword(string password)
    {
        var Encrypted = "";

        foreach (var item in password)
        {
            Encrypted += (char)((int)item + 4);
        }
        return Encrypted;
    }

    public static bool VerifyPassword(string EncryptedPassword, string enteredPassword)
    {
        return EncryptedPassword == EncryptPassword(enteredPassword);
    }
}