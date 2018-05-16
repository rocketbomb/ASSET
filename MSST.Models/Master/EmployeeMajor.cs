using System;
using System.Collections.Generic;
using ASSET.Common;

namespace ASSET.Models.Master
{
    public class EmployeeMajor : Base
	{
		public EmployeeMajor()
		{
			
		}

		public int EmployeeMajorId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

		public virtual Employee Employee { get; set; }
	}
}
