using System.ComponentModel.DataAnnotations;

namespace NguyenQuocviet.Models
{
    public class comment
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
