using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityTourist.Models
{
    public class Place
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("City")]
        public int CityId { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public string Tips { get; set; }
        public string Coordinates { get; set; } 
        public string[]? Images { get; set; }

    }
}
