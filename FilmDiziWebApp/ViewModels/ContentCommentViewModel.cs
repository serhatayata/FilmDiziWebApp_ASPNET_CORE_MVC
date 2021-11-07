using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDiziWebApp.ViewModels
{
    public class ContentCommentViewModel
    {
        public virtual Content Content { get; set; }
        public virtual IEnumerable<ContentComment> ContentComments { get; set; }
    }
}
