using System;
using System.Collections.Generic;
using ASSET.Common;

namespace ASSET.Models.Master
{
    public class AssetWarrantyCompany : Base
	{
		public AssetWarrantyCompany()
		{
			
		}

		public virtual ICollection<Base> Common { get; set; }

		public int AssetWarrantyCompanyId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }

		public virtual AssetWarranty AssetWarranty { get; set; }
	}
}
