using System;
using System.Collections.Generic;
using ASSET.Common;

namespace ASSET.Models.Master
{
    public class Employee : Base
    {
		private readonly Utility u = new Utility();

		public Employee()
		{
			
		}


		public int EmployeeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }

		public virtual EmployeeMajor Major { get; set; }

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
