using Microsoft.EntityFrameworkCore;
using PinewoodAssessment.Domain.Entities;

namespace PinewoodAssessment.Persistence.Context;

public class UserDbContext : DbContext
{
    public UserDbContext()
    {
    }

    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    public async Task<int> SaveChangesAsync()
    {
        return await base.SaveChangesAsync();
    }
}
