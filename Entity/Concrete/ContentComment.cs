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
        public virtual User User { get; set; }
        [Required(ErrorMessage = "Content cannot be empty")]
        public Content Content { get; set; }
        public string Body { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime AddedTime { get; set; }
    }
}
