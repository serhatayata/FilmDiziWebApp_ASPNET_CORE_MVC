using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Category:IEntity
    {
        public int  CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Images { get; set; }
        public bool isDeleted { get; set; }
        public virtual ICollection<Content> Content { get; set; }
    }
}
