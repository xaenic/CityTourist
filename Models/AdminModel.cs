using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace CityTourist.Models;

    public class AdminModel
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; }  = string.Empty;
        public string Name { get; set; } = string.Empty;
    }

