using System;


namespace ASSET.Models.Master
{
    public class EmployeeFaculty
	{
        public int EmployeeFacultyId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

		public EmployeeMajor Major { get; set; }
		
	}
}
