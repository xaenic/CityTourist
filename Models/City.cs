using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CityTourist.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string State { get; set; }
        public string Image { get; set; }

        // Navigation property for the relationship with Place
        public List<Place>? Places { get; set; } = new List<Place>();
    }
}
