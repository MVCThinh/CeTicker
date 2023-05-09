using System;
using System.Collections.Generic;

namespace RWeb.Models
{
    public partial class EmployeeOnLeave
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public int? ApprovedTp { get; set; }
        public int? ApprovedHr { get; set; }
        public int? TimeOnLeave { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? TotalTime { get; set; }
        public int? Type { get; set; }
        public int? TypeIsReal { get; set; }
        public decimal? TotalDay { get; set; }
        public string Reason { get; set; }
        public string Note { get; set; }
        public bool? IsApprovedTp { get; set; }
        public bool? IsApprovedHr { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsCancelTp { get; set; }
        public bool? IsCancelHr { get; set; }
        public bool? IsCancelRegister { get; set; }
        public int? DecilineApprove { get; set; }
        public string ReasonCancel { get; set; }
        public DateTime? DateCancel { get; set; }
        public bool? DeleteFlag { get; set; }
    }
}
