namespace CityTourist.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
