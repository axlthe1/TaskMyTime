using Microsoft.EntityFrameworkCore;
using TaskMyTime.Context;
using TaskMyTime.Interfaces;
using TaskMyTime.Models;

namespace TaskMyTime.Services;

public class ProjectService : IProjectService
{
	private readonly TaskMyTimeContext _dbContext;

	public ProjectService(TaskMyTimeContext dbContext)
	{
		_dbContext = dbContext;
	}
	public async Task<List<Project>> GetProjects()
	{
		return await _dbContext.Projects.ToListAsync();
	}

	public async Task SaveProject(Project project)
	{
		_dbContext.Update(project);
		await _dbContext.SaveChangesAsync();
	}

	public async Task AddProject(Project project)
	{
		_dbContext.Projects.Add(project);
		await _dbContext.SaveChangesAsync();
	}
}
