using System;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activities.Commands;

public class CreateActivity
{
    public class Command : IRequest<string>
    {
        public required EntActivity Activity { get; set; } = null!;
    }

    public class Handler(AppDbContext context):IRequestHandler<Command,string>
    {
        public async Task<string> Handle(Command request, CancellationToken cancellationToken)
        {
            if (request.Activity == null) throw new ArgumentNullException(nameof(request.Activity), "Activity cannot be null");

            context.Activities.Add(request.Activity);
            await context.SaveChangesAsync(cancellationToken);
            return request.Activity.Id;
        }
    }
  


}
