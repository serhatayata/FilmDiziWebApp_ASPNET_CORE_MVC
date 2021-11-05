using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Content:IEntity
    {
        public int ContentID { get; set; }
        [Required(ErrorMessage = "Name cannot be empty")]
        [StringLength(150, ErrorMessage = "Name length can't be less than 1 or greater than 150 characters.", MinimumLength = 1)]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Year { get; set; }
        [Range(1, 10, ErrorMessage = "IMDB must be between 1-10")]
        public double IMBD { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime AddedTime { get; set; }
        [MaxLength(2000,ErrorMessage = "This content cannot be more than 2000 characters")]
        public string Information { get; set; }
        public string Image { get; set; }
        [Required(ErrorMessage ="You have to choose if it is a movie or not.")]
        public bool IsItMovie { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
