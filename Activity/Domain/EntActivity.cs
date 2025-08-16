using System;
using System.ComponentModel.DataAnnotations;

namespace Domain;

public class EntActivity
{
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string? Title { get; set; }
    public DateTime Date { get; set; }
    public required string Description { get; set; }
    public required string Category { get; set; }
    public bool IsCancelled { get; set; }

    //Location
    public required string City { get; set; }
    public required string Venue { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }

}
