using System;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activities.Commands;

public class EditActivity
{
    public class Command : IRequest
    {
        public required EntActivity Activity { get; set; }
    }

    public class Handler(AppDbContext context) : IRequestHandler<Command>
    {
        public async Task Handle(Command request, CancellationToken cancellationToken)
        {
            // Example usage of 'context' to find and update an activity
            var activity = await context.Activities.FindAsync([request.Activity.Id ], cancellationToken);
            if (activity == null)
            {
                throw new Exception("Activity not found");
            }

            // mapper.Map(request.Activity, activity);

            activity.Title = request.Activity.Title;
            activity.Description = request.Activity.Description;
            activity.Date = request.Activity.Date;
            activity.Category = request.Activity.Category;
            activity.City = request.Activity.City;
            activity.Venue = request.Activity.Venue;

            await context.SaveChangesAsync(cancellationToken);
        }
    }

}
