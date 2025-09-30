using System;
using Domain;
using MediatR;
using Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.Activities.Queries;

public class GetActivityList
{
    public class Query : IRequest<List<EntActivity>>
    { }
  
    public class Handler(AppDbContext context) : IRequestHandler<Query, List<EntActivity>>
    {
       public async Task<List<EntActivity>> Handle(Query request, CancellationToken cancellationToken)
        {
            return await context.Activities.ToListAsync(cancellationToken);
        }
    }
}
