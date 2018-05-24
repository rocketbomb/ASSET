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
		public Asset Asset { get; set; }
		public Employee Employee { get; set; }
		public EmployeeMajor EmployeeMajor { get; set; }
		public EmployeeFaculty EmployeeFaculty { get; set; }
		public EmployeeUniversity EmployeeUniversity { get; set; }



	}
}
