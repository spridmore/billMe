using Microsoft.EntityFrameworkCore;
using Bills_Project_Backend.Controllers;

namespace Bills_Project_Backend
{
  public class CommentContext : DbContext
  {
    public CommentContext(DbContextOptions<CommentContext> options) : base(options)
    {
    }
    public DbSet<Comment> Comments { get; set; }
  }


}