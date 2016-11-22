using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleAspNetMvcArchProject.Data.Domain
{
    [Table("Person")]
    public class Person: AuditableEntity
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(20)]
        public string Phone { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [Display(Name="Country")]
        public int CountryId { get; set;  }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

    }
}
