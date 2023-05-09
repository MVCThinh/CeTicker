using System;
using System.Collections.Generic;

namespace RWeb.Models
{
    public partial class EmployeeFoodOrder
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        public int Quantity { get; set; }
        public DateTime? DateOrder { get; set; }
        public string Note { get; set; }
        public bool? IsApproved { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public int? DecilineApprove { get; set; }
    }
}
