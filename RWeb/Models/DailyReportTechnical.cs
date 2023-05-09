namespace RWeb.Models
{
    public partial class DailyReportTechnical
    {
        public int Id { get; set; }
        public int? MasterId { get; set; }
        public int? UserReport { get; set; }
        public DateTime? DateReport { get; set; }
        public int? ProjectId { get; set; }
        public string Content { get; set; }
        public string Results { get; set; }
        public string Problem { get; set; }
        public string ProblemSolve { get; set; }
        public string PlanNextDay { get; set; }
        public string Note { get; set; }
        public bool? Confirm { get; set; }
        public string Backlog { get; set; }
        public int? DeleteFlag { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? Type { get; set; }
        public int? ReportLate { get; set; }
        public int? OldProjectId { get; set; }
        public decimal? TotalHours { get; set; }
        public int? StatusResult { get; set; }
        public int? WorkPlanDetailId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Project Project { get; set; }
        public virtual Users UserReportNavigation { get; set; }
    }
}
