using System;
using System.Collections.Generic;
using ASSET.Common;


namespace ASSET.Models.Master
{
    public class AssetMaster : Base
    {
		public AssetMaster()
		{
			
		}

		public int AssetMasterId { get; set; }
		public AssetDetail AssetDetail { get; set; }
        public AssetWarranty AssetWarranty { get; set; }
		public AssetDepreciation AssetDepreciation { get; set; }


	}
}
