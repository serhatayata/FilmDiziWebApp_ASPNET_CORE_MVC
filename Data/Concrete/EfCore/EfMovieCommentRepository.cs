using Data.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete.EfCore
{
    public class EfMovieCommentRepository : IMovieCommentRepository
    {
        public void Add(MovieComment entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(MovieComment entity)
        {
            throw new NotImplementedException();
        }

        public MovieComment Get(Expression<Func<MovieComment, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<MovieComment> GetAll(Expression<Func<MovieComment, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(MovieComment entity)
        {
            throw new NotImplementedException();
        }
    }
}
