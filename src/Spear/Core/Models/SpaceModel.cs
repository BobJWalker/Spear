using System.ComponentModel.DataAnnotations.Schema;

namespace Spear.Core.Models
{
    [Table("Space")]
    public class SpaceModel : BaseOctopusModel
    {
        public int InstanceId { get; set; }
        public required string Name { get; set; }
    }
}
