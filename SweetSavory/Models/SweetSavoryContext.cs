using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SweetSavory.Models
{
  public class SweetSavoryContext : IdentityDbContext<ApplicationUser>
  {

    public SweetSavoryContext(DbContextOptions options) : base(options) { }
  }
}