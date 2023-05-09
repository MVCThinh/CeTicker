namespace RWeb.Models
{
    public partial class DailyReportTechnicalMaster
    {
        public int Id { get; set; }
        public int? UserReport { get; set; }
        public DateTime? DateReport { get; set; }
        public int? Type { get; set; }
        public int? ReportLate { get; set; }
        public int? DeleteFlag { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}
