using System;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Persistence;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Application.Activities.Queries;
using Application.Activities.Commands;

namespace ActivityAPI.Controllers;

// public class ActivityController(AppDbContext appDbContext,IMediator mediator) : BaseApiController
public class ActivityController() : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<EntActivity>>> GetActivities()
    {
        // return await appDbContext.Activities.ToListAsync();
        return await Mediator.Send(new GetActivityList.Query());

    }

    [HttpGet("{id}")]
    public async Task<ActionResult<EntActivity>> GetActivityById(string id)
    {
        // var activity = await appDbContext.Activities.FindAsync(id);
        // if (activity == null) return NotFound("Activity not found");
        // return activity;
        return await Mediator.Send(new GetActivityDetails.Query { Id = id });
    }

    [HttpPost]
    public async Task<ActionResult<string>> CreateActivity(EntActivity activity)
    {
        return await Mediator.Send(new CreateActivity.Command { Activity = activity });
    }

    [HttpPut]
    public async Task<IActionResult> EditActivity(EntActivity activity)
    {
        try
        {
            await Mediator.Send(new EditActivity.Command { Activity = activity });
            return NoContent();
        }
        catch (Exception ex)
        {
            return NotFound(ex.Message);
        }
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteActivity(string id)
    {
        try
        {
            await Mediator.Send(new DeleteActivity.Command { Id = id });
             return Ok();

        }
        catch (Exception ex)
        {
            return NotFound(ex.Message);
        }
       
    }

}
