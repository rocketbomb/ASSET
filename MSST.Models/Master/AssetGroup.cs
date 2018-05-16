using System;
using ASSET.Common;

namespace ASSET.Models.Master
{
    public class AssetGroup : Base
	{
        public int AssetGroupId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
		public string AssetId { get; set; }

		public virtual AssetDetail AssetDetail { get; set; }
	}
}
