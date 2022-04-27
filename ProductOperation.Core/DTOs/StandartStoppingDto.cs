using System.ComponentModel.DataAnnotations;

namespace ProductOperation.Core.DTOs
{
    public class StandartStoppingDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Boş Bırakılamaz")]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh:mm tt}")]
        //[DataType(DataType.Time)]
        public TimeSpan StartTime { get; set; }
        [Required(ErrorMessage = "Boş Bırakılamaz")]
        public TimeSpan EndTime { get; set; }
        [Required(ErrorMessage = "Boş Bırakılamaz")]
        public string StoppingReason { get; set; }
        public TimeSpan TotalTime { get; set; }
    }
}
