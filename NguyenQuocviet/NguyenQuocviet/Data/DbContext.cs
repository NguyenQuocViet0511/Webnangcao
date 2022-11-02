using Microsoft.EntityFrameworkCore;
using NguyenQuocviet.Models;

namespace NguyenQuocviet.Data
{
    public class Dbcontext : DbContext
    {
        public Dbcontext(DbContextOptions<Dbcontext> opt) : base(opt)
        {


        }
        #region DbSet
        public DbSet<User>? Users { get; set; }
        public DbSet<comment>? comments { get; set; }

        #endregion
    }
}