using Microsoft.EntityFrameworkCore;
using Relations.Models;

namespace Relations.Database;

public class RelationsDbContext : DbContext
{
    public RelationsDbContext()
    {
        
    }

    public DbSet<LectureRoom> LectureRooms { get; set; }

    public DbSet<Subject> Subjects { get; set; }

    public DbSet<Teacher> Teachers { get; set; }

    public DbSet<Lecture> Lectures { get; set; }

    public DbSet<Assistant> Assistants { get; set; }

    public DbSet<Schedule> Schedules { get; set; }

    public DbSet<Dean> Deans { get; set; }

    public DbSet<Curator> Curators { get; set; }

    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<Departament> Departaments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("");
    }
}
