using System.ComponentModel.DataAnnotations;
namespace CityTourist.Models;
public class GalleryImage 
{
    [Key]
    public byte[] File { get; set; }
    // Other properties like FileName, ContentType, etc. could be added here
}