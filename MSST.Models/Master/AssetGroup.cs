﻿using System;
using System.Collections.Generic;
using ASSET.Common;

namespace ASSET.Models.Master
{
    public class AssetGroup : Base
	{
		private readonly Utility u = new Utility();

		public AssetGroup()
		{

		}

		public int AssetGroupId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
		public string AssetId { get; set; }


		public virtual Asset Asset { get; set; }
	}
}
