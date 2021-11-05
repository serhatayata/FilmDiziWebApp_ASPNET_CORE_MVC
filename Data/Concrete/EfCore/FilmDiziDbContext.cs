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
        public virtual DbSet<Content> Contents { get; set; }
        public virtual DbSet<ContentComment> ContentComments { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<AboutUs> AboutUss { get; set; }

    }
}
