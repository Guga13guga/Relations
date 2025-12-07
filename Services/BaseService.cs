using Relations.Database;

namespace Relations.Services;

public abstract class BaseService
{
    protected readonly RelationsDbContext _context;

    protected BaseService()
    {
        _context = new RelationsDbContext();
    }
}
