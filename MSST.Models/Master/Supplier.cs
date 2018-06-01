using System;
using System.Collections.Generic;
using ASSET.Common;

namespace ASSET.Models.Master
{
    public class Supplier : Base
	{
		private readonly Utility u = new Utility();

		public Supplier()
		{
		}

		public int SupplierId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }

		public SupplierGroup SupplierGroup { get; set; }

		public void setDelete()
		{
			IsDelete = 1;
			UpdateBy = u.getUser();
			UpdateDate = u.getCurrentDate();
		}
	}
}
