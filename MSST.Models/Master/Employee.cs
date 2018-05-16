﻿using System;
using ASSET.Common;

namespace ASSET.Models.Master
{
    public class Employee : Base
    {
        public int EmployeeId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }

		public virtual EmployeeMajor Major { get; set; }
	}
}