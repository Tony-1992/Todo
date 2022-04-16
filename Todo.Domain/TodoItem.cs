namespace Todo.Domain
{
    public class TodoItem : BaseEntity
    {
        public string Description { get; set; }
        public bool IsComplete { get; set; } = false;
        public DateTime ModifiedAt { get; set; }

    }
}
