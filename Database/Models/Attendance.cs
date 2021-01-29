using System;
using System.Collections.Generic;

#nullable disable

namespace Database.Models
{
    public partial class Attendance
    {
        public int RecordId { get; set; }
        public string EmpId { get; set; }
        public string EmployeeName { get; set; }
        public string ImageUrl { get; set; }
        public int? Type { get; set; }
        public int? AccountId { get; set; }
        public DateTime? Time { get; set; }
        public string CompanyId { get; set; }
        public string Mode { get; set; }
        public string LocationName { get; set; }
        public string DeviceName { get; set; }
        public string DepartmentName { get; set; }
        public string DeviceId { get; set; }
    }
}
