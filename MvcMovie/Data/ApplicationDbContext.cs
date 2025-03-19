using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using MVCMOVIE.Models;

namespace MvcMovie.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Person { get ; set; }
        public DbSet<MVCMOVIE.Models.DaiLy> DaiLy { get; set; } = default!;
        public DbSet<MVCMOVIE.Models.HeThongPhanPhoi> HeThongPhanPhoi { get; set; } = default!;
    }
}