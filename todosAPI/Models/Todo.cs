using System;
namespace todosAPI.Models
{
	public class Todo
	{
		public int Id { get; set; }
		public string? title { get; set; }
		public string? description { get; set; }
		public bool isCompleted { get;set;}

		public Todo()
		{
		}
	}
}

