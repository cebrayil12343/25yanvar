using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teamsd.Models
{
    public class Team
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 30)]
        public string Name { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twiter { get; set; }
        [StringLength(maximumLength: 30)]
        public string Professeion { get; set; }
        public string? Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

    }
}
