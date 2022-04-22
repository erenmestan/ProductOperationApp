using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
