namespace BlazorWebAssemblyDemo.Client.Models
{
    public class TaskModel
    {
        public string TaskName { get; set; }
        public bool IsCompleted { get; set; }
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
