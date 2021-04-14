using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Request;
using Books;
namespace Users
{
    public class UsersModel
    {
        [Required]
        [Key]
        public Guid UserID { get; set; }
        public string UserName { get; set; }
        public string UserRole { get; set; }
        public virtual ICollection<RequestModel> Requests { get; set; }
        public UsersModel(Guid userId, string userName, string userRole)
        {
            UserID = userId;
            UserName = userName;
            UserRole = userRole;
        }
    }
}