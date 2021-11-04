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
    public class EfContentRepository : IContentRepository
    {
        public void Add(Content entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Content entity)
        {
            throw new NotImplementedException();
        }

        public Content Get(Expression<Func<Content, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetAll(Expression<Func<Content, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Content entity)
        {
            throw new NotImplementedException();
        }
    }
}
