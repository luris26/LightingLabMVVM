﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMobileEmployee.Models
{
    internal class Employee
    {
        public string? EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? Email { get; set; }
        public bool IsPartTimer { get; set; }

    }
}
