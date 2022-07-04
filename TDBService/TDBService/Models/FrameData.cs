using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDBService.Models
{
    internal class FrameData
    {
        [Key][Required] public Guid FrameId { get; set; }  // ref to the frame to which it belongs
        [Key][Required] public short ChannelId { get; set; }  // ref to the channel data contained in the frame. Composes a multiple key
        [Required] public float Value { get; set; }
    }
}
