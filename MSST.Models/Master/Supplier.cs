using System;
using ASSET.Common;

namespace ASSET.Models.Master
{
    public class Supplier : Base
	{
        public int SupplierId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }

    }
}
