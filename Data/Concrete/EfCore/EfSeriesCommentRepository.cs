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
    public class EfSeriesCommentRepository : ISeriesCommentRepository
    {
        public void Add(SeriesComment entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(SeriesComment entity)
        {
            throw new NotImplementedException();
        }

        public SeriesComment Get(Expression<Func<SeriesComment, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<SeriesComment> GetAll(Expression<Func<SeriesComment, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(SeriesComment entity)
        {
            throw new NotImplementedException();
        }
    }
}
