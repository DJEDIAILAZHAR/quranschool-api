using Microsoft.EntityFrameworkCore;
using QuranSchool.Api.Models;

namespace QuranSchool.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Student> Students => Set<Student>();
}
