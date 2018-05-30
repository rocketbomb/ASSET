using System;
using System.Collections.Generic;
using ASSET.Common;


namespace ASSET.Models.Master
{
    public class EmployeeUniversity : Base
	{
		

		public EmployeeUniversity()
		{
			
		}

		public int EmployeeUniversityId { get; set; }
        public string Code { get; set; }
        public string NameThai { get; set; }
		public string NameEng { get; set; }

		public EmployeeFaculty Faculty { get; set; }

		public virtual ICollection<Asset> Asset { get; set; }

		public virtual Ownership Ownership { get; set; }

		

	}
}
