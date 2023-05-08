namespace RWeb.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerShortName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public int? CustomerType { get; set; }
        public int? StatusDisable { get; set; }
        public string Website { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNote { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsDeleted { get; set; }
        public string NoteDelivery { get; set; }
        public string NoteVoucher { get; set; }
        public string CheckVoucher { get; set; }
        public string HardCopyVoucher { get; set; }
        public DateTime? ClosingDateDebt { get; set; }
        public string Debt { get; set; }
        public string AdressStock { get; set; }
        public string TaxCode { get; set; }
    }
}
