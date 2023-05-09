using System;
using System.Collections.Generic;

namespace RWeb.Models
{
    public partial class EmployeeEarlyLate
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public int? ApprovedId { get; set; }
        public bool? IsApproved { get; set; }
        public DateTime? DateRegister { get; set; }
        public decimal? TimeRegister { get; set; }
        public int? Unit { get; set; }
        public int? Type { get; set; }
        public string Reason { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public int? ApprovedTp { get; set; }
        public bool? IsApprovedTp { get; set; }
        public int? DecilineApprove { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public string ReasonDeciline { get; set; }
    }
}
