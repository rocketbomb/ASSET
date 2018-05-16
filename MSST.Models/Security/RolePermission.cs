using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASSET.Models.Security
{
    public class RolePermission
    {
        public int RolePermissionId { get; set; }

        public int RoleId { get; set; }
        public virtual Role Role { get; set; }

        public int PermissionId { get; set; }
        public virtual Permission Permission { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CreateBy { get; set; }
        public int isActive { get; set; }
        public int isDelete { get; set; }
    }
}
