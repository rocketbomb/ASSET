using System;
using System.Collections.Generic;
using ASSET.Common;

namespace ASSET.Models.Master
{
    public class EmployeeMajor : Base
	{
		private readonly Utility u = new Utility();

		public EmployeeMajor()
		{
			
		}

		public int EmployeeMajorId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

		public virtual Employee Employee { get; set; }

		public virtual ICollection<Asset> Asset { get; set; }

		public virtual Ownership Ownership { get; set; }

		public void setDelete()
		{
			IsDelete = 1;
			UpdateBy = u.getUser();
			UpdateDate = u.getCurrentDate();
		}
	}
}
