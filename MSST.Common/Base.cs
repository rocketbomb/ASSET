using System;

namespace ASSET.Common
{
    public class Base
    {
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CreateBy { get; set; }
        public int isActive { get; set; }
        public int isDelete { get; set; }

    }
}
