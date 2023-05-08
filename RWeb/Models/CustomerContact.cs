namespace RWeb.Models
{
    public partial class CustomerContact
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CustomerTeam { get; set; }
        public string CustomerPart { get; set; }
        public string CustomerPosition { get; set; }
    }
}
