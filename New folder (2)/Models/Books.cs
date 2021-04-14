using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Category;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Books
{
    public class BooksModel 
    {
        
        [Key]
        public Guid BookID { get; set; }
        [Required]
        public string BookName { get; set; }
        [Key]
        public Guid CategoryID { get; set; }
        public virtual CategoryModel Category { get; set; }
        public BooksModel(Guid bookID, string bookName, Guid categoryID)
        {
            BookID = bookID;
            BookName = bookName;
            CategoryID = categoryID;
        }

    }
}