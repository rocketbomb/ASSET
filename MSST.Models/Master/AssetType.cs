using System;
using ASSET.Common;

namespace ASSET.Models.Master
{
    public class AssetType : Base
	{
        public int AssetTypeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

		public virtual AssetDetail AssetDetail { get; set; }
	}
}
