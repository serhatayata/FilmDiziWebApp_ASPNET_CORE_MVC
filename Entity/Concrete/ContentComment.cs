using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class ContentComment:IEntity
    {
        [Key]
        public int CommentID { get; set; }
       
        public int ContentID { get; set; }
        [Required(ErrorMessage = "Content cannot be empty")]
        public virtual Content Content { get; set; }
      
        public string Body { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime AddedTime { get; set; }
        public bool isDeleted { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
