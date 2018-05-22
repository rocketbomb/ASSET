﻿using System;
using System.Collections.Generic;
using ASSET.Common;


namespace ASSET.Models.Master
{
	public class AssetCategory : Base
	{
	


		public int AssetCategoryId { get; set; }
		public string Code { get; set; }
		public string Name { get; set; }
		
		//public virtual ICollection<Base> CommonTable { get; set; }

		public virtual Asset Asset { get; set; }
		
	}
}
