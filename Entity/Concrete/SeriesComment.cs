using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class SeriesComment:IEntity
    {
        [Key]
        public int SeriesCommentID { get; set; }
        public User User { get; set; }
        [Required(ErrorMessage = "Content cannot be empty")]
        public Series Series { get; set; }
        public string Content { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime AddedTime { get; set; }
    }
}
