using System;


namespace ASSET.Models.Master
{
    public class EmployeeMajor
	{
        public int EmployeeMajorId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }


		public virtual Employee Employee { get; set; }

	}
}
