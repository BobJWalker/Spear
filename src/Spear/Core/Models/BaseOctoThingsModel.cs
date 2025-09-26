using System.ComponentModel.DataAnnotations.Schema;

namespace Spear.Core.Models
{
    public class BaseOctoThingsModel : BaseOctopusModel
    {
        public int SpaceId { get; set; }
        public required string Name { get; set; }
    }
}