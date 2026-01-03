using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using ToDoListMinimalAPI;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ToDoListDb>(options => options.UseInMemoryDatabase("ToDoListDb"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();
var todoItems = app.MapGroup("/todolistitems");

todoItems.MapGet("/", async (ToDoListDb db) => await db.ToDoLists.ToListAsync());

todoItems.MapGet("/completed", async (ToDoListDb db) => await db.ToDoLists.Where(t => t.IsComplete).ToListAsync());

todoItems.MapGet("/{id}", async (int id, ToDoListDb db) => await db.ToDoLists.FindAsync(id) is ToDoList toDo ? Results.Ok(toDo) : Results.NotFound());

todoItems.MapPost("/", async (ToDoList toDo, ToDoListDb db) =>
{
	db.Add(toDo);
	await db.SaveChangesAsync();
	return Results.Created($"/todolistitems/{toDo.Id}",toDo);
});

todoItems.MapPut("/{id}", async (int id, ToDoList inputToDo, ToDoListDb db) =>
{
	var todo = await db.ToDoLists.FindAsync(id);
	if (todo is null)
		return Results.NotFound();

	todo.Name = inputToDo.Name;
	todo.IsComplete = inputToDo.IsComplete;

	await db.SaveChangesAsync();
	return Results.NoContent();
});

todoItems.MapDelete("/{id}", async(int id,ToDoListDb db) =>
{
	if (await db.ToDoLists.FindAsync(id) is ToDoList toDo)
	{
		db.ToDoLists.Remove(toDo);
		await db.SaveChangesAsync();
		return Results.NoContent();
	}
	return Results.NotFound();
});

app.Run();
