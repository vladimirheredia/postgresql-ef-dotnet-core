using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoAppData.models;

namespace TodoApp.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        readonly TodoAppContext Context;
        public TodoController(TodoAppContext context) 
            => Context = context;

        [HttpGet]
        public IActionResult GetTodo()
        {

            var todos = Context.Todo.ToList();
            return Ok(todos);
        }

        [HttpPost]
        public IActionResult CreateTodo()
        {
            var todo = new Todo()
            {
                Title = "Do Laundry!",
                Body = @"You're laundry is looking a little sad."
            };

            Context.Add(todo);
            Context.SaveChanges();
            //this is what we'll return 
            return Ok("Successfully created a todo item");
        }

        [HttpPut("{id:guid}")]
        public IActionResult UpdateTodo(Guid id)
        {
            var todo = Context.Todo.Find(id);
            todo.Title = "This is an updated title";
            todo.Body = "You still need to do the laundry!";
            Context.Update(todo);
            Context.SaveChanges();

            return Ok("Sucessfully updated todo item");
        }

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteTodo(Guid id)
        {
            var todo = Context.Todo.Find(id);
            Context.Remove(todo);
            Context.SaveChanges();

            return Ok("Sucessfully Removed the item!");
        }
    }
}