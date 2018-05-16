using System;



namespace ASSET.Models.Master
{
    public class AssetMaster
    {
		public int AssetMasterId { get; set; }
		public AssetDetail AssetDetail { get; set; }
        public virtual AssetWarranty AssetWarranty { get; set; }
      

      

    }
}
