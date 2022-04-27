namespace ProductOperation.Core.Models
{
    public class StandartStopping : BaseEntity
    {
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string StoppingReason { get; set; }

    }
}
