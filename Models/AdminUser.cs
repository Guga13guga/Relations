using System.ComponentModel.DataAnnotations.Schema;

namespace Relations.Models;

[Table("AdminUsers")]
public class AdminUser : BaseModel
{
    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? PasswordHashed { get; set; }

    public string? PhoneNumber { get; set; }

    public DateTime LastSignIn { get; set; }
}
