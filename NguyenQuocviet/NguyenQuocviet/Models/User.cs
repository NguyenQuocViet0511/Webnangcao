using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenQuocviet.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public string Age { get; set; }

        public string sex  { get; set; }    
    }
}
