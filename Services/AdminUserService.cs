using Relations.Models;

namespace Relations.Services;

public class AdminUserService : BaseService
{
    public AdminUserService() : base()
    {    
        
    }

    public void AddNewUser(AdminUser user)
    {
        if (_context.AdminUser.Any(i => i.Email == user.Email))
        {
            throw new ArgumentException("Such user already exist!!!");
        }
        else
        {
            _context.AdminUser.Add(user);
            _context.SaveChanges();
        }
    }

    public AdminUser GetAdminUser(int id)
    {
        var user = _context.AdminUser.FirstOrDefault(i => i.Id == id);
        if (user == null)
        {
            throw new ArgumentNullException("No user Exist");
        }
        return user;
    }

    public void DeleteUser(int id)
    {
        var user = GetAdminUser(id);
        if (user != null)
        {
            _context.AdminUser.Remove(user);
            _context.SaveChanges();
        }
    }

    public List<AdminUser> GetAllUsers()
    {
        var allUsers = _context.AdminUser.ToList();
        return allUsers;
    }

    public AdminUser UpdateUser(AdminUser user)
    {
        var dbUser = GetAdminUser(user.Id);
        dbUser.PhoneNumber = user.PhoneNumber;
        dbUser.Name = user.Name;
        dbUser.Email = user.Email;
        dbUser.PasswordHashed = user.PasswordHashed;
        dbUser.LastSignIn = user.LastSignIn;
        _context.SaveChanges();
        return dbUser;
    }

    public List<AdminUser> SortUser(bool Isdsc)
    {
        var all = GetAllUsers();
        if (Isdsc)
        {
           return all.OrderByDescending(i => i.Id).ToList();
        }

        return all.OrderBy(i=>i.Id).ToList();
    }
}
