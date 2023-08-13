using System;
using todosAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace todosAPI.Data
{
	public class DataContext : DbContext
    {
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}

		public DbSet<Todo> Todos { get; set; }
	}
}

