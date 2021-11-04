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
    public class EfContentCommentRepository : IContentCommentRepository
    {
        public void Add(ContentComment entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ContentComment entity)
        {
            throw new NotImplementedException();
        }

        public ContentComment Get(Expression<Func<ContentComment, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ContentComment> GetAll(Expression<Func<ContentComment, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(ContentComment entity)
        {
            throw new NotImplementedException();
        }
    }
}
