using System.ComponentModel.DataAnnotations.Schema;

namespace Spear.Core.Models
{
    [Table("Instance")]
    public class InstanceModel : BaseOctopusModel
    {
        public required string Name { get; set; }
        public required string Url { get; set; }
        public required string ApiKey { get; set; }
    }
}