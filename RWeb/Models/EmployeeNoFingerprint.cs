using System;
using System.Collections.Generic;

namespace RWeb.Models
{
    public partial class EmployeeNoFingerprint
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public int? ApprovedTp { get; set; }
        public DateTime? DayWork { get; set; }
        public bool? IsApprovedTp { get; set; }
        public string Note { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? ApprovedHr { get; set; }
        public bool? IsApprovedHr { get; set; }
        public int? Type { get; set; }
        public int? DecilineApprove { get; set; }
        public string ReasonDeciline { get; set; }
    }
}
