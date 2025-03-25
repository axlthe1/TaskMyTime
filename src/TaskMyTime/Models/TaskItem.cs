namespace TaskMyTime.Models;

public class TaskItem
{
	public int Id { get; set; }
	public string Title { get; set; } = "New Task";
	public string Description { get; set; } = "";
	public Project Project { get; set; }
	public DateTime? StartDate { get; set; }
	public TimeSpan? StartTime { get; set; }
	public bool IsTimerRunning { get; set; }
	public TimeSpan ElapsedTime { get; set; }


}

