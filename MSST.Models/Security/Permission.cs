using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASSET.Models.Security
{
    public class Permission
    {
        public int PermissionId { get; set; }
        public string Description { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CreateBy { get; set; }
        public int isActive { get; set; }
        public int isDelete { get; set; }
    }
}
