using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class AboutUs:IEntity
    {
        [Key]
        public int AboutUsID { get; set; }
        [MaxLength(3000, ErrorMessage = "This content cannot be more than 2000 characters")]
        public string Information { get; set; }
        public bool isDeleted { get; set; }
    }
}
