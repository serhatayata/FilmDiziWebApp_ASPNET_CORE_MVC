using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete.EfCore
{
    public class FilmDiziDbContext:DbContext
    {
        public FilmDiziDbContext(DbContextOptions<FilmDiziDbContext> options):base(options)
        {

        }
        public DbSet<Content> Contents { get; set; }
        public DbSet<ContentComment> ContentComments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }


    }
}
