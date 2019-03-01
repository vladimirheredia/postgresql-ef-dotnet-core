using System;

namespace TodoAppData.models
{
    public class Todo
    {
        public Todo()
        {
            Id = new Guid();
            CreatedOn = DateTime.Now;
            isCompleted = false;
        }

        public Guid Id { get; private set; }
        public DateTime CreatedOn { get; private set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public bool isCompleted { get;  private set; }
    }
}
