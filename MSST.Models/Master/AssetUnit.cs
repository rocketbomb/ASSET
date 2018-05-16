using System;
using ASSET.Common;

namespace ASSET.Models.Master
{
    public class AssetUnit : Base
	{
        public int AssetUnitId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

		public virtual AssetDetail AssetDetail { get; set; }
	}
}
