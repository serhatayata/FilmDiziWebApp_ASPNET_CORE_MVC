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
    public class EfSeriesRepository : ISeriesRepository
    {
        public void Add(Series entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Series entity)
        {
            throw new NotImplementedException();
        }

        public Series Get(Expression<Func<Series, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Series> GetAll(Expression<Func<Series, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Series entity)
        {
            throw new NotImplementedException();
        }
    }
}
