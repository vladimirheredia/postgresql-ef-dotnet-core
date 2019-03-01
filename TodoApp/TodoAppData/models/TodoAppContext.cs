using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TodoAppData.models.ModelConfigurations;

namespace TodoAppData.models
{
    public class TodoAppContext : DbContext
    {
        public TodoAppContext(DbContextOptions<TodoAppContext> options ): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder) 
            => builder.ApplyConfiguration(new TodoConfiguration());

        public DbSet<Todo> Todo { get; set; }
    }
}
