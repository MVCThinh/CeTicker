using System;
using System.Collections.Generic;

namespace RWeb.Models
{
    public partial class EmployeeBussinessVehicle
    {
        public int Id { get; set; }
        public int? EmployeeBussinesId { get; set; }
        public int? EmployeeVehicleBussinessId { get; set; }
        public decimal? Cost { get; set; }
        public string BillImage { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string Note { get; set; }
    }
}
