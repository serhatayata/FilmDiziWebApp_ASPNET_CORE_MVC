using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmDiziWebApp.ViewModels
{
    public class FilterViewModel
    {
        public Category Category { get; set; }
        public Content Content { get; set; }
        public int CategoryID { get; set; }
        public List<Category> CategoryList { get; set; }
    }
}
