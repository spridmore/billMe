using Microsoft.EntityFrameworkCore;
using Bills_Project_Backend.Controllers;

namespace Bills_Project_Backend
{
  public class UserContext : DbContext
  {
    public UserContext(DbContextOptions<UserContext> options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
  }


}