using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class AppDbContext(DbContextOptions Options):DbContext(Options)
{
   public required DbSet<Activity>  Activities { get; set; }
}
