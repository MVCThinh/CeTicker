using System;
using System.Collections.Generic;

namespace RWeb.Models
{
    public partial class EmployeeBussiness
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public bool? IsApproved { get; set; }
        public int? ApprovedId { get; set; }
        public DateTime? DayBussiness { get; set; }
        public int? TypeBusiness { get; set; }
        public string Location { get; set; }
        public int? VehicleId { get; set; }
        public decimal? CostVehicle { get; set; }
        public decimal? CostBussiness { get; set; }
        public decimal? TotalMoney { get; set; }
        public bool? NotChekIn { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public bool? Overnight { get; set; }
        public decimal? CostOvernight { get; set; }
        public bool? WorkEarly { get; set; }
        public decimal? CostWorkEarly { get; set; }
        public int? DecilineApprove { get; set; }
        public int? ApprovedHr { get; set; }
        public bool? IsApprovedHr { get; set; }
        public string ReasonDeciline { get; set; }
    }
}
