using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using ASSET.Common;

namespace ASSET.Models.Master
{
	public class Asset : Base
	{

		private readonly Utility u = new Utility();

		public Asset()
		{

		}

		public int AssetId { get; set; }
		public string Code { get; set; }
		public string Barcode { get; set; }

		//[Column("Thai Name", TypeName = "ntext")]
		public string NameThai { get; set; }

		//[Column("English Name", TypeName = "ntext")]
		public string NameEng { get; set; }

		//[Column("Old Code", TypeName = "ntext")]
		public string OldCode { get; set; }

		public virtual AssetUnit Unit { get; set; }
		public virtual AssetCategory Category { get; set; }
		public virtual AssetGroup Group { get; set; }
		public virtual AssetType Type { get; set; }

		public string Color { get; set; }
		public string Size { get; set; }

		public string Brand { get; set; }
		public string Model { get; set; }
		public string SerialNo { get; set; }

		public virtual Location Location { get; set; }
		public virtual Ownership Ownership { get; set; }

		public AssetWarranty AssetWarranty { get; set; }
		public AssetDepreciation AssetDepreciation { get; set; }

		public void setDelete()
		{
			IsDelete = 1;
			UpdateBy = u.getUser();
			UpdateDate = u.getCurrentDate();
		}

	}
}
