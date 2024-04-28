using System.ComponentModel.DataAnnotations;

namespace CatdogWeb.Domain
{
    public class EntityBase
    {
        [Key]
        public int? Id { get; set; }
    }
}
