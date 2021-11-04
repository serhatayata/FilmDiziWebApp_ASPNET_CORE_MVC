using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Movie:IEntity
    {
        [Key]
        public int MovieID { get; set; }
        [Required(ErrorMessage = "Movie name cannot be empty")]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Year { get; set; }
        [Range(1, 10, ErrorMessage = "IMDB must be between 1-10")]
        public double IMDB { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime AddedTime { get; set; }
    }
}
