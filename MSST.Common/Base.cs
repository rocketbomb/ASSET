using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASSET.Common
{
	public abstract class Base
	{
		public Base()
		{
			CreateBy = "System";
		}

		//public int BaseId { get; set; }

		[Required]
		public string CreateBy { get; set; }
		public DateTime? CreateDate { get; set; }

		public string UpdateBy { get; set; }
		public DateTime? UpdateDate { get; set; }

		public int IsActive { get; set; }
		public int IsDelete { get; set; }

	}

	public class Utility
	{

		public DateTime CurrentDate()
		{
			return DateTime.Now;
		}
	}
}
