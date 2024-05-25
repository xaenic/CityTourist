using System.ComponentModel.DataAnnotations;

namespace CityTourist.Models
{
    public class Place
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Tips { get; set; }
        public string Coordinates { get; set; } 
        public GalleryImage[]? Gallery { get; set; }
    }
}
