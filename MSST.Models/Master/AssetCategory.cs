using System;
using System.Collections.Generic;
using ASSET.Common;


namespace ASSET.Models.Master
{
	public class AssetCategory : Base
	{
		public AssetCategory()
		{
			//CommonTable = new HashSet<Base>();
		}


		public int AssetCategoryId { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		
		//public virtual ICollection<Base> CommonTable { get; set; }

		public virtual AssetDetail AssetDetail { get; set; }
		
	}
}
