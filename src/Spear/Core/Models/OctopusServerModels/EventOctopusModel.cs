using System.Collections.Generic;

namespace Spear.Core.Models.OctopusServerModels
{
    public class EventOctopusModel : BaseOctopusServerModel
    {
        public required string SpaceId { get; set; }
        public required string Message { get; set; }
        public required List<string> RelatedDocumentIds { get; set; }
    }
}
