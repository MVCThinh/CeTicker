using System;
using System.Collections.Generic;

namespace RWeb.Models
{
    public partial class EmployeeApprove
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public string Code { get; set; }
        public string FullName { get; set; }
    }
}
