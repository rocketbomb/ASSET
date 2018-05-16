using System;
using System.Collections.Generic;
using ASSET.Common;

namespace ASSET.Models.Master
{
    public class SupplierGroup : Base
	{
		public SupplierGroup()
		{
		}

		public int SupplierGroupId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

		public virtual Supplier Supplier { get; set; }

	}
}
