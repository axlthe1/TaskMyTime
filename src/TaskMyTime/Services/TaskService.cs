using Microsoft.EntityFrameworkCore;
using TaskMyTime.Context;
using TaskMyTime.Interfaces;
using TaskMyTime.Models;

namespace TaskMyTime.Services;

public class TaskService : ITaskService
{
	private readonly TaskMyTimeContext _dbContext;

	public TaskService (TaskMyTimeContext dbContext)
	{
		_dbContext = dbContext;
	}
	public async Task<List<TaskItem>> GetTasks(Project project)
	{
		return await _dbContext.Tasks.Include(t => t.Project)
				.Where(t => t.Project.Id == project.Id).ToListAsync();

	}

	public async Task AddTask(TaskItem task)
	{
		_dbContext.Tasks.Add(task);
		await _dbContext.SaveChangesAsync();
	}

	public async Task SaveTaskAsync(TaskItem task)
	{
		_dbContext.Tasks.Update(task);
		await _dbContext.SaveChangesAsync();
	}
}
