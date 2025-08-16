using System;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Persistence;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Application.Activities.Queries;
namespace API.Controllers;

public class ActivitiesController : BaseApiController
{
    private readonly AppDbContext _context;
    private readonly IMediator _mediator;
    public ActivitiesController(AppDbContext context, IMediator mediator)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }


    [HttpGet]
    public async Task<ActionResult<List<Activity>>> GetActivities()
    {
        // var activities = await _context.Activities.ToListAsync();
        //   return Ok(activities);
        return await _mediator.Send(new GetActivityList.Query());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Activity>> GetActivity(string id)
    {
        // var activity = await _context.Activities.FindAsync(id);
        // if (activity == null) return NotFound();
        // return Ok(activity);

        return await _mediator.Send(new GetActivityDetails.Query{Id = id});
    }

    // Additional methods for creating, updating, and deleting activities can be added here

}
