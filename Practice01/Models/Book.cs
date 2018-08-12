using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice01.Models
{
    public class Book
    {
        public string BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public string Picture { get; set; }
    }
}