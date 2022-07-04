using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDBService.Models
{
    internal class Frame
    {
        [Required] public Guid TelemetryId { get; set; }  // ref to the telemetry streaming to which it belongs
        [Key][Required] public Guid FrameId { get; set; }
        [Required] public DateTime TimeStamp { get; set; }
    }
}
