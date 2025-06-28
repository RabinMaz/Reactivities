using System;
using Domain;

namespace Persistence;

public class DbInitializer
{
    public static async Task Initialize(AppDbContext context)
    {
        if (context.Activities.Any()) return;
        var activities = new List<Activity>
        {
            new() {
                title = "Past Activity 1",
                Date = DateTime.Now.AddMonths(-2),
                description = "Activity 2 months ago",
                category = "drinks",
                city = "London",
                venue = "The Lamb and Flag, 33, Rose Street, Seven Dials, Covent Garden, London, Greater London, England, WC2E 9EB, United Kingdom",
                latitude = 51.51171665,
                longitude = -0.1256611057818921,
            },
            new() {
                title = "Past Activity 2",
                Date = DateTime.Now.AddMonths(-1),
                description = "Activity 1 month ago",
                category = "culture",
                city = "Paris",
                venue = "Louvre Museum, Rue Saint-Honoré, Quartier du Palais Royal, 1st Arrondissement, Paris, Ile-de-France, Metropolitan France, 75001, France",
                latitude = 48.8611473,
                longitude = 2.33802768704666
            },
            new() {
                title = "Future Activity 1",
                Date = DateTime.Now.AddMonths(1),
                description = "Activity 1 month in future",
                category = "culture",
                city = "London",
                venue = "Natural History Museum",
                latitude = 51.496510900000004,
                longitude = -0.17600190725447445
            },
            new() {
                title = "Future Activity 2",
                Date = DateTime.Now.AddMonths(2),
                description = "Activity 2 months in future",
                category = "music",
                city = "London",
                venue = "The O2",
                latitude = 51.502936649999995,
                longitude = 0.0032029278126681844
            },
            new()
            {
                title = "Future Activity 3",
                Date = DateTime.Now.AddMonths(3),
                description = "Activity 3 months in future",
                category = "drinks",
                city = "London",
                venue = "The Mayflower",
                latitude = 51.501778,
                longitude = -0.053577
            },
            new()
            {
                title = "Future Activity 4",
                Date = DateTime.Now.AddMonths(4),
                description = "Activity 4 months in future",
                category = "drinks",
                city = "London",
                venue = "The Blackfriar",
                latitude = 51.512146650000005,
                longitude = -0.10364680647106028
            },
            new()
            {
                title = "Future Activity 5",
                Date = DateTime.Now.AddMonths(5),
                description = "Activity 5 months in future",
                category = "culture",
                city = "London",
                venue = "Sherlock Holmes Museum, 221b, Baker Street, Marylebone, London, Greater London, England, NW1 6XE, United Kingdom",
                latitude = 51.5237629,
                longitude = -0.1584743
            },
            new()
            {
                title = "Future Activity 6",
                Date = DateTime.Now.AddMonths(6),
                description = "Activity 6 months in future",
                category = "music",
                city = "London",
                venue = "Roundhouse, Chalk Farm Road, Maitland Park, Chalk Farm, London Borough of Camden, London, Greater London, England, NW1 8EH, United Kingdom",
                latitude = 51.5432505,
                longitude = -0.15197608174931165
            },
            new()
            {
                title = "Future Activity 7",
                Date = DateTime.Now.AddMonths(7),
                description = "Activity 2 months ago",
                category = "travel",
                city = "London",
                venue = "River Thames, England, United Kingdom",
                latitude = 51.5575525,
                longitude = -0.781404
            },
            new()
            {
                title = "Future Activity 8",
                Date = DateTime.Now.AddMonths(8),
                description = "Activity 8 months in future",
                category = "film",
                city = "London",
                venue = "River Thames, England, United Kingdom",
                latitude = 51.5575525,
                longitude = -0.781404
            }

        };

        context.Activities.AddRange(activities);
        await context.SaveChangesAsync();
    }
}
