namespace RWeb.Models
{
    public partial class CustomerPart
    {
        public int Id { get; set; }
        public string PartName { get; set; }
        public string PartCode { get; set; }
        public int? CustomerId { get; set; }
        public int? Stt { get; set; }
    }
}
