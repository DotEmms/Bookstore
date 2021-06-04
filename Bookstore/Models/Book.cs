using Bookstore.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class Book : BaseModel
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public DateTime YearOfPublication { get; set; }
        public int Edition { get; set; }
        public string FirstNameAuthor { get; set; }
        public string LastNameAuthor { get; set; }
    }
}
