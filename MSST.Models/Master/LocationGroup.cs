using System;
using System.Collections.Generic;
using ASSET.Common;

namespace ASSET.Models.Master
{
	public class LocationGroup : Base
	{
		public LocationGroup()
		{
		}

		public int LocationGroupId { get; set; }
		public string Code { get; set; }
		public string Barcode { get; set; }
		public string Name { get; set; }
		
		public virtual Location Location { get; set; }
	}
}
