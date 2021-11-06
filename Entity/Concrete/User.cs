using Core.Entities;
using Entity.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class User:IEntity
    {
        [Key]
        public int UserID { get; set; }
        [Required(ErrorMessage = "Username cannot be empty!")]
        [Display(Name = "User Name")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password cannot be empty!")]
        [StringLength(24, MinimumLength = 8, ErrorMessage = "Password cannot be less than 8 characters!")]
        [RegularExpression("^.*(?=.{8,})(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$", ErrorMessage = "Password is invalid, At least one lower case letter, one upper case letter, one special character,one number, 8-24 characters length")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Name cannot be empty!")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        [StringLength(150, ErrorMessage = "Name length can't be less than 1 or greater than 150 characters.", MinimumLength = 1)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Surname cannot be empty!")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Email cannot be empty!")]
        [Display(Name = "E-mail ")]
        [RegularExpression("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage = "Check your mail address")]
        public string Email { get; set; }
        public char Role { get; set; }
        [MustBeTrue()]
        public bool TermsAccepted { get; set; }
        public virtual ICollection<ContentComment> ContentComment { get; set; }

    }
}
