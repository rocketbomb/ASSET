using System;
using System.Collections.Generic;
using ASSET.Common;

namespace ASSET.Models.Master
{
    public class Ownership : Base
	{
		public Ownership()
		{
		}

		public int OwnershipId { get; set; }
		public virtual Asset Asset { get; set; }
		public virtual Employee Employee { get; set; }
		public virtual EmployeeMajor EmployeeMajor { get; set; }
		public virtual EmployeeFaculty EmployeeFaculty { get; set; }
		public virtual EmployeeUniversity EmployeeUniversity { get; set; }

	}
}
