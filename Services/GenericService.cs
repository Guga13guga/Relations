using Microsoft.EntityFrameworkCore;
using Relations.Database;

namespace Relations.Services;

public class GenericService<T> where T : class
{
    private readonly RelationsDbContext _context;
    private readonly DbSet<T> _dbSet;

    public GenericService()
    {
        _context = new RelationsDbContext();
        _dbSet = _context.Set<T>();
    }

    public void AddNewItem(T item)
    {
        _dbSet.Add(item);
        _context.SaveChanges();
    }

    public List<T> GetAll()
    {
        return _dbSet.ToList();
    }

    public T? Get(int id)
    {
        return _dbSet.Find(id);
    }

    public void Delete(int id)
    {
        var item = Get(id);
        if (item != null)
        {
            _dbSet.Remove(item);
            _context.SaveChanges();
        }
    }

    public void Update(T item)
    {
        _dbSet.Update(item);
        _context.SaveChanges();
    }

    public List<T> SortById(bool ascending)
    {
        if (ascending)
        {
            return _dbSet.OrderBy(i => i).ToList();
        }

        return _dbSet.OrderByDescending(i => i).ToList();
    }
}
