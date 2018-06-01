using System;
using System.Collections.Generic;
using ASSET.Common;


namespace ASSET.Models.Master
{
	public class AssetDepreciation : Base
	{
		private readonly Utility u = new Utility();

		public int AssetDepreciationId { get; set; }
		public DateTime PurchaseDate { get; set; }
		public double Cost { get; set; }
		public double CalculatePrice { get; set; }
		public double RemainPrice { get; set; }
		public double UsefulLife { get; set; }
		public double DepreciateRatio { get; set; }
		public double DepreciateOpen { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public double DayOffCalculate { get; set; }
		public double AssetAge { get; set; }
		public double DepreciatePerDay { get; set; }
		public double Remark { get; set; }

		public virtual Asset Asset { get; set; }
		
	}
}
