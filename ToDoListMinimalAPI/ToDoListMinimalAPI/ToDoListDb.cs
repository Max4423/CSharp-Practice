using Microsoft.EntityFrameworkCore;

namespace ToDoListMinimalAPI
{
	public class ToDoListDb : DbContext
	{
		public ToDoListDb(DbContextOptions<ToDoListDb> options) : base(options)
		{
		}
		public DbSet<ToDoList> ToDoLists => Set<ToDoList>();
	}
}
