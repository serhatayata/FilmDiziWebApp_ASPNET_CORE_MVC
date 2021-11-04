﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class MovieComment:IEntity
    {
        [Key]
        public int MovieCommentID { get; set; }
        [Required(ErrorMessage = "Username cannot be empty")]
        public User User { get; set; }
        [Required(ErrorMessage = "Movie cannot be empty")]
        public Movie Movie { get; set; }
        [Required(ErrorMessage = "Content cannot be empty")]
        public string Content { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime AddedTime { get; set; }
    }
}
