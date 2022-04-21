namespace ProductOperation.Core.DTOs
{
    public class ProductionOperationDTO
    {
        public string No { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public bool Status { get; set; }
        public string StoppingReason { get; set; }
    }
}
