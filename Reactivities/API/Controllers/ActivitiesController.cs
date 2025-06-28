using System;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Persistence;
using Microsoft.EntityFrameworkCore;
namespace API.Controllers;

public class ActivitiesController : BaseApiController
{
    private readonly AppDbContext _context;
    public ActivitiesController(AppDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }


    [HttpGet]
   public async Task<ActionResult<List<Activity>>> GetActivities()
    {
        var activities = await _context.Activities.ToListAsync();
        return Ok(activities);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Activity>> GetActivity(string id)
    {
        var activity = await _context.Activities.FindAsync(id);
        if (activity == null) return NotFound();
        return Ok(activity);
    }

    // Additional methods for creating, updating, and deleting activities can be added here

}
