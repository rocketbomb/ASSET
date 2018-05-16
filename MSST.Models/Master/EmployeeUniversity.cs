using System;


namespace ASSET.Models.Master
{
    public class EmployeeUniversity
	{
        public int EmployeeUniversityId { get; set; }
        public string Code { get; set; }
        public string NameThai { get; set; }
		public string NameEng { get; set; }

		public EmployeeFaculty Faculty { get; set; }
	}
}
