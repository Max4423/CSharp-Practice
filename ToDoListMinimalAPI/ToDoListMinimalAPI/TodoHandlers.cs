using Microsoft.EntityFrameworkCore;
namespace ToDoListMinimalAPI
{
	public static class TodoHandlers
	{
		public static async Task<IResult> GetAllToDos(ToDoListDb db)
		{
			return TypedResults.Ok(await db.ToDoLists
				.Select(x => new ToDoListDTO(x))
				.ToListAsync());
		}

		public static async Task<IResult> GetCompletedToDos(ToDoListDb db)
		{
			return TypedResults.Ok(await db.ToDoLists
				.Where(t => t.IsComplete)
				.Select(x => new ToDoListDTO(x))
				.ToListAsync());
		}

		public static async Task<IResult> GetToDo(int id, ToDoListDb db)
		{
			return await db.ToDoLists.FindAsync(id)
				is ToDoList toDo
					? TypedResults.Ok(new ToDoListDTO(toDo))
					: TypedResults.NotFound();
		}

		public static async Task<IResult> CreateToDo(ToDoListDTO todoItemDTO, ToDoListDb db)
		{
			var todoItem = new ToDoList
			{
				IsComplete = todoItemDTO.IsComplete,
				Name = todoItemDTO.Name
			};

			db.ToDoLists.Add(todoItem);
			await db.SaveChangesAsync();
			return TypedResults.Created($"/todolistitems/{todoItem.Id}", new ToDoListDTO(todoItem));
		}

		public static async Task<IResult> UpdateToDo(int id, ToDoListDTO todoItemDTO, ToDoListDb db)
		{
			var todo = await db.ToDoLists.FindAsync(id);
			if (todo is null)
				return TypedResults.NotFound();

			todo.Name = todoItemDTO.Name;
			todo.IsComplete = todoItemDTO.IsComplete;

			await db.SaveChangesAsync();
			return TypedResults.NoContent();
		}
		public static async Task<IResult> DeleteToDo(int id, ToDoListDb db)
		{
			if (await db.ToDoLists.FindAsync(id) is ToDoList toDo)
			{
				db.ToDoLists.Remove(toDo);
				await db.SaveChangesAsync();
				return TypedResults.NoContent();
			}
			return TypedResults.NotFound();
		}
	}
}
