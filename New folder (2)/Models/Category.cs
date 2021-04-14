using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Books;
using System.ComponentModel.DataAnnotations;

namespace Category
{
    public class CategoryModel
    {
        [Required]
        [Key]
        public Guid CategoryID { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<BooksModel> Books { get; set; }
        public CategoryModel(Guid categoryID, string categoryName)
        {
            CategoryID = categoryID;
            CategoryName = categoryName;
        }

    }
}
