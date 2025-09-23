using System.ComponentModel.DataAnnotations;

namespace Spear.Core.Models
{
    public abstract class BaseModel
    {
        [Key]
        public int Id { get; set; }
    }
}
