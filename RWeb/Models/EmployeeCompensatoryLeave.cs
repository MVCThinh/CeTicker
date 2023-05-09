using System;
using System.Collections.Generic;

namespace RWeb.Models
{
    public partial class EmployeeCompensatoryLeave
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime? DateValue { get; set; }
        public bool? IsApproved { get; set; }
        public int? Approver { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool? DeleteFlag { get; set; }
    }
}
