using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOperation.Core.DTOs
{
    public class StandartStoppingDto
    {
        public int Id { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string StoppingReason { get; set; }
        public TimeSpan TotalTime { get; set; }
    }
}
