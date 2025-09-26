using System;

namespace Spear.Core.Models
{
    public class SyncModel : BaseModel
    {
        public int InstanceId { get; set; }
        public required string State { get; set; }
        public required string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Started { get; set; }
        public DateTime? Completed { get; set; }
        public DateTime? SearchStartDate { get; set; }
        public int? RetryAttempts { get; set; }
    }
}
