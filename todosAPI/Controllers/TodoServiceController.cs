using System;
using Microsoft.AspNetCore.Mvc;


namespace todosAPI.Controllers
{
    [ApiController]
	[Route("api/[controller]")]
    
    public class TodoServiceController : ControllerBase
	{

        private readonly ITodoService _todoService;
        public TodoServiceController(ITodoService todoService)
		{
            _todoService = todoService;
        }

        [HttpGet(Name = "Getting todos")]
        public async Task<ActionResult<List<Todo>>> getTodos()
        {
            return Ok(await _todoService.getTodos());
        }

        [HttpGet("{id}",Name = "Getting single todo")]
        public async Task<ActionResult<Todo>> getSingleTodo(int id)
        {
            return Ok(await _todoService.getSingleTodo(id));
        }

        [HttpPost(Name ="Adding todo")]
        public async Task<ActionResult<List<Todo>>> addTodo(Todo todo)
        {
            return Ok(await _todoService.addTodo(todo));
        }

        [HttpPut(Name = "Updating todo")]
        public async Task<ActionResult<List<Todo>>> updateTodo(Todo todo)
        {
            return Ok(await _todoService.updateTodo(todo));
        }

        [HttpDelete(Name = "Deleting todo")]
        public async Task<ActionResult<List<Todo>>> deleteTodo(int id)
        {
            return Ok(await _todoService.deleteTodo(id));
        }
    }

    
}

