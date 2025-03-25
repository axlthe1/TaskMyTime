using kDg.FileBaseContext.Extensions;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using Photino.Blazor;
using TaskMyTime.Context;
using TaskMyTime.Interfaces;
using TaskMyTime.Services;

namespace TaskMyTime;

public class Program
{
	[STAThread]
	public static void Main(string[] args)
	{
		var appBuilder = PhotinoBlazorAppBuilder.CreateDefault(args);

		appBuilder.Services.AddLogging();
		appBuilder.Services.AddMudServices();

		appBuilder.Services.AddTransient<IProjectService, ProjectService>();
		appBuilder.Services.AddTransient<ITaskService, TaskService>();
		appBuilder.Services.AddDbContext<TaskMyTimeContext>();

		appBuilder.RootComponents.Add<App>("app");

		var app = appBuilder.Build();

		app.MainWindow
			.SetSize(1400, 800)
			.SetDevToolsEnabled(true)
			.SetLogVerbosity(0)
			//.SetIconFile("favicon.ico")
			.SetTitle("TaskMyTime");

		AppDomain.CurrentDomain.UnhandledException += (sender, error) =>
		{
			app.MainWindow.ShowMessage("Fatal exception", error.ExceptionObject.ToString());
		};

		app.Run();
	}
}

