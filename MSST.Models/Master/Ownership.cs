using System;
using System.Collections.Generic;
using ASSET.Common;

namespace ASSET.Models.Master
{
    public class Ownership : Base
	{
		private readonly Utility u = new Utility();

		public Ownership()
		{
		}

		public int OwnershipId { get; set; }
		public Asset Asset { get; set; }
		public Employee Employee { get; set; }
		public EmployeeMajor EmployeeMajor { get; set; }
		public EmployeeFaculty EmployeeFaculty { get; set; }
		public EmployeeUniversity EmployeeUniversity { get; set; }

		public void setDelete()
		{
			IsDelete = 1;
			UpdateBy = u.getUser();
			UpdateDate = u.getCurrentDate();
		}

	}
}
