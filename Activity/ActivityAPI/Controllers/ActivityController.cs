using System;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Persistence;
using Microsoft.EntityFrameworkCore;

namespace ActivityAPI.Controllers;

public class ActivityController(AppDbContext appDbContext) : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<EntActivity>>> GetActivities()
    {
        return await appDbContext.Activities.ToListAsync();

    }

    [HttpGet("{id}")]
    public async Task<ActionResult<EntActivity>> GetActivityById(string id)
    {
        var activity = await appDbContext.Activities.FindAsync(id);
        if (activity == null) return NotFound("Activity not found");
        return activity;
    }

    [HttpPost]
    public async Task<ActionResult<EntActivity>> CreateActivity(EntActivity activity)
    {
        if (activity == null) return BadRequest("Activity cannot be null");
        appDbContext.Activities.Add(activity);
        await appDbContext.SaveChangesAsync();
        return CreatedAtAction(nameof(GetActivityById), new { id = activity.Id }, activity);
    }

}
