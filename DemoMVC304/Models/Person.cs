using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC304.Models
{
    [Table("Person")]  
    public class Person
    {
        [Key]                        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? PersonId { get; set; }                  
        public string? FullName { get; set; }
        public string? Address { get; set; }
    }
}
