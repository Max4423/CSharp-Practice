using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Rewrite;

namespace WebApplication1
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			var app = builder.Build();

			var rewriteOptions = new RewriteOptions().AddRedirect("tasks/(.*)", "todos/$1");
			app.UseRewriter(rewriteOptions);

			app.Use(async (context, next) =>
			{
				Console.WriteLine($"[{context.Request.Method} {context.Request.Path} {DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} Started]");
				await next(context);
				Console.WriteLine($"[{context.Request.Method} {context.Request.Path} {DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} Finished]");
			});
			var todos = new List<Todo>();
			app.MapGet("/todos", () => todos);

			app.MapGet("/todos/{id}", Results<Ok<Todo>, NotFound> (int id) =>
			{
				var targetTodo = todos.SingleOrDefault(t => id == t.Id);
				return targetTodo is null
				? TypedResults.NotFound()
				: TypedResults.Ok(targetTodo);
			});
			app.MapPost("/todos", (Todo task) =>
			{
				todos.Add(task);
				return TypedResults.Created("/todos/{id}", task);
			});

			app.MapDelete("/todos/{id}", (int id) =>
			{
				todos.RemoveAll(t => id == t.Id);
				return TypedResults.NoContent();
			});

			app.Run();
		}
	}

	public record Todo(int Id, string Name, DateTime DueDate, bool IsCompleted);
}
