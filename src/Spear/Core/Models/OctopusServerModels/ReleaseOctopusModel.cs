using System;

namespace Spear.Core.Models.OctopusServerModels
{
    public class ReleaseOctopusModel : BaseOctopusServerModel
    {
        public DateTime Assembled { get; set; }
        public required string Version { get; set; }
    }
}
