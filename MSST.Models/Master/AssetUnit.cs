using System;
using System.Collections.Generic;
using ASSET.Common;

namespace ASSET.Models.Master
{
    public class AssetUnit : Base
	{
		public AssetUnit()
		{
		
		}

		public virtual ICollection<Base> Common { get; set; }

		public int AssetUnitId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }


		public virtual AssetDetail AssetDetail { get; set; }
	}
}
