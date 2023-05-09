using System;
using System.Collections.Generic;

namespace RWeb.Models
{
    public partial class EmployeePayrollDetail
    {
        public int Id { get; set; }
        public int? PayrollId { get; set; }
        public int? Stt { get; set; }
        public int? EmployeeId { get; set; }
        public decimal? BasicSalary { get; set; }
        public decimal? TotalMerit { get; set; }
        public decimal? TotalSalaryByDay { get; set; }
        public decimal? AllowanceMeal { get; set; }
        public decimal? ReferenceIndustry { get; set; }
        public decimal? RealIndustry { get; set; }
        public decimal? TotalAllowance { get; set; }
        public decimal? SalaryOneHour { get; set; }
        public decimal? OtHourWd { get; set; }
        public decimal? OtMoneyWd { get; set; }
        public decimal? OtHourWk { get; set; }
        public decimal? OtMoneyWk { get; set; }
        public decimal? OtHourHd { get; set; }
        public decimal? OtMoneyHd { get; set; }
        public decimal? OtTotalSalary { get; set; }
        public decimal? AllowanceOtEarly { get; set; }
        public decimal? BussinessMoney { get; set; }
        public decimal? NightShiftMoney { get; set; }
        public decimal? Bonus { get; set; }
        public decimal? Other { get; set; }
        public decimal? RealSalary { get; set; }
        public decimal? SocialInsurance { get; set; }
        public decimal? AdvancePayment { get; set; }
        public decimal? Insurances { get; set; }
        public decimal? UnionFees { get; set; }
        public decimal? DepartmentalFees { get; set; }
        public decimal? Punish5S { get; set; }
        public decimal? TotalDeduction { get; set; }
        public decimal? ActualAmountReceived { get; set; }
        public bool? Sign { get; set; }
        public bool? GetCash { get; set; }
        public string Note { get; set; }
    }
}
