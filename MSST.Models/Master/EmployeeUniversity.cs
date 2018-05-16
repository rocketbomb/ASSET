﻿using System;
using ASSET.Common;

namespace ASSET.Models.Master
{
    public class EmployeeUniversity : Base
	{
        public int EmployeeUniversityId { get; set; }
        public string Code { get; set; }
        public string NameThai { get; set; }
		public string NameEng { get; set; }

		public EmployeeFaculty Faculty { get; set; }
	}
}