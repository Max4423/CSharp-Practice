var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.UseStatusCodePages();

app.Run(async (context) =>
{
	var path = context.Request.Path;
	var method = context.Request.Method;

	// 1. Пріоритетні маршрути (специфічні шляхи)
	if (path == "/redirect")
	{
		context.Response.Redirect("https://gemini.google.com/");
		return;
	}

	if (path == "/time")
	{
		context.Response.ContentType = "text/html; charset=utf-8";
		await context.Response.WriteAsync($"<h1>Current Time: {DateTime.Now}</h1>");
		return;
	}

	if (path == "/postuser")
	{
		var form = context.Request.Form;
		string name = form["name"];
		string age = form["age"];
		context.Response.ContentType = "text/html; charset=utf-8";
		await context.Response.WriteAsync($"<div><p>Name: {name}</p><p>Age: {age}</p></div>");
		return;
	}

	if (path == "/file")
	{
		context.Response.Headers.ContentDisposition = "attachment; filename=\"1.jpg\"";
		await context.Response.SendFileAsync("C:\\Users\\miksi\\Pictures\\1.jpg");
		return;
	}

	if (path == "/json")
	{
		await context.Response.WriteAsJsonAsync(new Person { Name = "Max", Age = 12 });
		return;
	}

	if (path == "/index")
	{
		await context.Response.SendFileAsync("html/index.html");
		return;
	}

	context.Response.ContentType = "text/html; charset=utf-8";
	await context.Response.WriteAsync($"<h1>Path: '{path}' at {DateTime.Now}</h1>");
	await context.Response.WriteAsync($"<h2>Method: {method}</h2>");
	await context.Response.WriteAsync("<p><a href='/file'>Download image</a> | <a href='/json'>View JSON</a></p>");
});

app.Run();

public record Person
{
	public string Name { get; init; }
	public int Age { get; init; }
}