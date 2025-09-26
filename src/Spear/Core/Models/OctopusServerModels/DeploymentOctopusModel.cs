namespace Spear.Core.Models.OctopusServerModels
{
    public class DeploymentOctopusModel : BaseOctopusServerModel
    {
        public required string EnvironmentId { get; set; }
        public required string TenantId { get; set; }
        public required string Name { get; set; }

        public required DeploymentOctopusModelLinks Links { get; set; }

        public class DeploymentOctopusModelLinks
        {
            public required string Task { get; set; }
        }
    }
}
