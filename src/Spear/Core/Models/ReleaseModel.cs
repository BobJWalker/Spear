using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Spear.Core.Models
{
    [Table("Release")]
    public class ReleaseModel : BaseOctopusModel
    {
        public int ProjectId { get; set; }
        public required string Version { get; set; }
        public DateTime Created { get; set; }
    }
}
