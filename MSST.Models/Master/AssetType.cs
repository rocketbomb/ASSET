using System;
using System.Collections.Generic;
using ASSET.Common;

namespace ASSET.Models.Master
{
    public class AssetType : Base
	{
		public AssetType()
		{
		}

		public int AssetTypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

		public virtual AssetDetail AssetDetail { get; set; }

	}
}
