using TaskMyTime.Models;

namespace TaskMyTime.Interfaces;

public interface ITaskService
{
	Task<List<TaskItem>> GetTasks(Project project);
	Task AddTask(TaskItem task);
	Task SaveTaskAsync(TaskItem task);
}
