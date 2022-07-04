using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWebApp.Shared.Models
{
    internal class Telemetry
    {
        [Key][Required] public Guid TelemetryId { get; set; }
        [Required] public string Name { get; set; }
        [Required] public string Description { get; set; }
        [Required] public DateTime CreationTimestamp { get; set; }
        [Required] public string CreatedBy { get; set; }
        [Required] public int Duration { get; set; }  // duration of the telemetry streaming in milliseconds
    }
}
