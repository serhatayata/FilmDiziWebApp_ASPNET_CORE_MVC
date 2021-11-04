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

        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieComment> MovieComments { get; set; }
        public DbSet<Series> SeriesTb { get; set; }
        public DbSet<SeriesComment> SeriesComments { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
