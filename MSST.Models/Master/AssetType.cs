using System;
using System.Collections.Generic;
using ASSET.Common;

namespace ASSET.Models.Master
{
    public class AssetType : Base
	{
		private readonly Utility u = new Utility();

		public AssetType()
		{

		}

		public int AssetTypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

		public virtual Asset Asset { get; set; }

		public void setDelete()
		{
			IsDelete = 1;
			UpdateBy = u.getUser();
			UpdateDate = u.getCurrentDate();
		}
	}
}
