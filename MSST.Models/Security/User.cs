using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASSET.Models.Security
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string MobileNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int UserTypeId { get; set; }
        public virtual UserType UserType { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CreateBy { get; set; }
        public int isActive { get; set; }
        public int isDelete { get; set; }
    }
}
