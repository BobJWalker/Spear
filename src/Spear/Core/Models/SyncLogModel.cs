using System;

namespace Spear.Core.Models
{
    public class SyncLogModel : BaseModel
    {
        public int SyncId { get; set; }
        public DateTime Created { get; set; }
        public required string Type { get; set; }
        public required string Message { get; set; }
    }
}
