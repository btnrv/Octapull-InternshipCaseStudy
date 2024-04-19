using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OctaMeet.Models
{
    public class Meeting
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(300)")]
        public string Name { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        [Column(TypeName = "nvarchar(600)")]
        public string Description { get; set; }
    }
}
