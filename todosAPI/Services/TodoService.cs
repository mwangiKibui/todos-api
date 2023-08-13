using System;

namespace todosAPI.Services
{
	public class TodoService : ITodoService
	{
        private readonly DataContext _dbContext;

		public TodoService(DataContext dbContext)
		{
            _dbContext = dbContext;
		}

        public async Task<List<Todo>> addTodo(Todo todo)
        {
            try
            {
                _dbContext.Add(todo);
                await _dbContext.SaveChangesAsync();
                var todos = await _dbContext.Todos.ToListAsync();
                return todos;
            }catch(Exception error)
            {
                throw new Exception("An error occurred "+error.Message);
            }
        }

        public async Task<List<Todo>> deleteTodo(int id)
        {
            try
            {
                _dbContext.Remove(new Todo { Id = id });
                await _dbContext.SaveChangesAsync();
                var todos = await _dbContext.Todos.ToListAsync();
                return todos;
            }catch(Exception error)
            {
                throw new Exception("An error occurred "+error.Message);
            }
        }

        public async Task<Todo> getSingleTodo(int id)
        {
            try
            {
                Todo todo = await _dbContext.Todos.FirstOrDefaultAsync(todo => todo.Id == id);
                return todo;
            }catch(Exception error)
            {
                throw new Exception("An error occurred "+error.Message);
            }
        }

        public async Task<List<Todo>> getTodos()
        {
            try
            {
                var todos = await _dbContext.Todos.ToListAsync();
                return todos;
            }catch(Exception error)
            {
                throw new Exception("An error occurred "+error.Message);
            }
        }

        public async Task<List<Todo>> updateTodo(Todo todo)
        {
            try
            {
                _dbContext.Update(todo);
                await _dbContext.SaveChangesAsync();
                var todos = await _dbContext.Todos.ToListAsync();
                return todos;
            }catch(Exception error)
            {
                throw new Exception("An error occurred "+error.Message);
            }
        }
    }
}

