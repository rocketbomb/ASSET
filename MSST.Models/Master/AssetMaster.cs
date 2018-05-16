using System;
using ASSET.Common;


namespace ASSET.Models.Master
{
    public class AssetMaster : Base
    {
		public int AssetMasterId { get; set; }
		public AssetDetail AssetDetail { get; set; }
        public virtual AssetWarranty AssetWarranty { get; set; }
      

      

    }
}
