using kDg.FileBaseContext.Extensions;
using Microsoft.EntityFrameworkCore;
using TaskMyTime.Models;

namespace TaskMyTime.Context;

public class TaskMyTimeContext : DbContext
{
	public DbSet<TaskItem> Tasks { get; set; }
	public DbSet<Project> Projects { get; set; }


	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseFileBaseContextDatabase("my_local_db");
		base.OnConfiguring(optionsBuilder);
	}
}
