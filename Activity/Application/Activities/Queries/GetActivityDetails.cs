using System;
using Domain;
using MediatR;
using Microsoft.VisualBasic;
using Persistence;

namespace Application.Activities.Queries;

public class GetActivityDetails
{
    public class Query : IRequest<EntActivity>
    {
        public required string Id { get; set; }
    }
   
   public class Handler (AppDbContext context): IRequestHandler<Query, EntActivity>
    {

        public async Task<EntActivity> Handle(Query request, CancellationToken cancellationToken)
        {
            var activity = await context.Activities.FindAsync(request.Id);
            if (activity == null) throw new Exception("Activity not found");
            return activity;
        }
    }

}
