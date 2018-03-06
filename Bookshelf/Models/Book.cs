using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookshelf.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
    }
}