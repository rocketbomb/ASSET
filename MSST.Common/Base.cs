using System;
using System.Collections.Generic;

namespace ASSET.Common
{
	public abstract class Base
	{

		public int BaseId { get; set; }

		public string CreateBy { get; set; }
		public DateTime? CreateDate { get; set; }

		public string UpdateBy { get; set; }
		public DateTime? UpdateDate { get; set; }

		public int IsActive { get; set; }
		public int IsDelete { get; set; }

	}
}
