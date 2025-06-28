using System;
using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Activity
{
    [Key]
    public string id { get; set; } = Guid.NewGuid().ToString();
    public required string title { get; set; }
    public DateTime Date { get; set; }

    public required string description { get; set; }

    public required string category { get; set; }

    public bool Iscancelled { get; set; }

    //Location Props

    public required string city { get; set; }
    public required string venue { get; set; }
    public double latitude { get; set; }
    public double longitude { get; set; }
}
