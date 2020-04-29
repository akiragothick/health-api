using System.ComponentModel.DataAnnotations;

namespace Health.API.Models
{
    public class Ailment
    {
        [Key]
        public string Name { get; set; }
    }
}