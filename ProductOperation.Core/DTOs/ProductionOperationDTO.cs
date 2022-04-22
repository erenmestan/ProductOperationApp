using System.ComponentModel.DataAnnotations;

namespace ProductOperation.Core.DTOs
{
    public class ProductionOperationDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Boş Bırakılamaz")]
        public string No { get; set; }
        [Required(ErrorMessage = "Boş Bırakılamaz")]
        public DateTime StartDateTime { get; set; }
        [Required(ErrorMessage = "Boş Bırakılamaz")]
        public DateTime EndDateTime { get; set; }
        public bool Status { get; set; }
        public string StoppingReason { get; set; }
        public TimeSpan TotalTime { get; set; }
    }
}
