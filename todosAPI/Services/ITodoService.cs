using System;
namespace todosAPI.Services
{
	public interface ITodoService
	{
		Task<List<Todo>> getTodos(); // Getting all todos
		Task<Todo> getSingleTodo(int id); // Getting a single todo
		Task<List<Todo>> addTodo(Todo todo); // Adding a todo
		Task<List<Todo>> updateTodo(Todo todo); // Updating a todo
		Task<List<Todo>> deleteTodo(int id); // Deleting a todo
    }
}

