using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Users;
using System.ComponentModel.DataAnnotations;
using Books;
namespace Request
{
    public class RequestModel
    {
        [Key]
        public Guid RequestID { get; set; }
        public string RequestStatus { get; set; }
        [Required]
        public string RequestName { get; set; }
        [Key]
        public Guid UserID { get; set; }
        public string RequestDate { get; set; }
        public string UpdateRequestDate { get; set; }
        public virtual UsersModel Users { get; set; }

        public RequestModel(Guid requestID, string requestStatus, string requestName, Guid userID, string requestDate, string updateRequestDate)
        {
            RequestID = requestID;
            RequestStatus = requestStatus;
            RequestName = requestName;
            UserID = userID;
            RequestDate = requestDate;
            UpdateRequestDate = updateRequestDate;
        }
    }
}