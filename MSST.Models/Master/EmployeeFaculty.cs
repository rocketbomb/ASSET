using System;
using System.Collections.Generic;
using ASSET.Common;

namespace ASSET.Models.Master
{
    public class EmployeeFaculty : Base
	{
		public EmployeeFaculty()
		{
		}

		public int EmployeeFacultyId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

		public EmployeeMajor Major { get; set; }

		public virtual ICollection<AssetDetail> AssetDetail { get; set; }

		public virtual Ownership Ownership { get; set; }
	}
}
