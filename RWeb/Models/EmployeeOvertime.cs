using System;
using System.Collections.Generic;

namespace RWeb.Models
{
    public partial class EmployeeOvertime
    {
        public int Id { get; set; }
        public bool? IsApproved { get; set; }
        public int? EmployeeId { get; set; }
        public int? ApprovedId { get; set; }
        public DateTime? DateRegister { get; set; }
        public int? Location { get; set; }
        public int? TypeId { get; set; }
        public DateTime? TimeStart { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal? TimeReality { get; set; }
        public decimal? TotalTime { get; set; }
        public decimal? CostOvertime { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool? Overnight { get; set; }
        public decimal? CostOvernight { get; set; }
        public string Reason { get; set; }
        public int? DecilineApprove { get; set; }
        public int? ApprovedHr { get; set; }
        public bool? IsApprovedHr { get; set; }
        public string ReasonDeciline { get; set; }
    }
}
