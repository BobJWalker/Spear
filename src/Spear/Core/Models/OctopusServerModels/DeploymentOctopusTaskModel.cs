using System;

namespace Spear.Core.Models.OctopusServerModels
{
    public class DeploymentOctopusTaskModel : BaseOctopusServerModel
    {
        public DateTime QueueTime { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? CompletedTime { get; set; }
        public required string State { get; set; }
    }
}
