﻿using System;
using System.Collections.Generic;
using ASSET.Common;

namespace ASSET.Models.Master
{
    public class AssetUnit : Base
	{
		public AssetUnit()
		{
		
		}

		public int AssetUnitId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }


		public virtual Asset Asset { get; set; }
	}
}
