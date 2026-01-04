namespace ToDoListMinimalAPI
{
	public class ToDoListDTO
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public bool IsComplete { get; set; }

		public ToDoListDTO()
		{
		}
		public ToDoListDTO(ToDoList todoItem) =>
		(Id, Name, IsComplete) = (todoItem.Id, todoItem.Name, todoItem.IsComplete);
	}
}
