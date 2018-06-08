using System;
using System.Collections.Generic;
using ASSET.Common;


namespace ASSET.Models.Master
{
	public class AssetBrand : Base
	{

		private readonly Utility u = new Utility();

		public int AssetBrandId { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		
		//public virtual ICollection<Base> CommonTable { get; set; }

		public virtual Asset Asset { get; set; }

		public void setDelete()
		{
			IsDelete = 1;
			UpdateBy = u.getUser();
			UpdateDate = u.getCurrentDate();
		}
	}
}
