using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Books; 
using Request;
using System.ComponentModel.DataAnnotations;

namespace RequestDetails
{
    public class RequestDetailsModel
    {
        [Key]
        public string Key { get; set; }
        [Key]
        [Required]
        public Guid BookID { get; set; }
        [Key]
        [Required]
        public Guid RequestID { get; set; }
        public virtual RequestModel Requests { get; set; }
        public virtual BooksModel Books { get; set; }
    }
}