using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Health.API.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        
        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }
        public ICollection<Ailment> Ailments { get; set; }
        public ICollection<Medication> Medications { get; set; }
    }
}