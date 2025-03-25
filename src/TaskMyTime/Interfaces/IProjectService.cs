using TaskMyTime.Models;

namespace TaskMyTime.Interfaces;

public interface IProjectService
{
	Task<List<Project>> GetProjects();
	Task AddProject(Project project);
	Task SaveProject(Project project);
}
