using Microsoft.EntityFrameworkCore;
using ToDoListMinimalAPI;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ToDoListDb>(options => options.UseInMemoryDatabase("ToDoListDb"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApiDocument(config =>
{
	config.DocumentName = "TodoAPI";
	config.Title = "TodoAPI v1";
	config.Version = "v1";
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseOpenApi();
	app.UseSwaggerUi(config =>
	{
		config.DocumentTitle = "TodoAPI";
		config.Path = "/swagger";
		config.DocumentPath = "/swagger/{documentName}/swagger.json";
		config.DocExpansion = "list";
	});
}
var todoItems = app.MapGroup("/todolistitems");

todoItems.MapGet("/", TodoHandlers.GetAllToDos);

todoItems.MapGet("/completed", TodoHandlers.GetCompletedToDos);

todoItems.MapGet("/{id}", TodoHandlers.GetToDo);

todoItems.MapPost("/", TodoHandlers.CreateToDo);

todoItems.MapPut("/{id}", TodoHandlers.UpdateToDo);

todoItems.MapDelete("/{id}", TodoHandlers.DeleteToDo);

app.Run();