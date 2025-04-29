
using C_.ClassWork._23_24.Command;

public class AddTaskCommand : ITaskCommand
{
    private List<TaskToDo> _tasks;
    public AddTaskCommand(List<TaskToDo> tasks)
    {
        _tasks = tasks;
    }
    public void Execute()
    {
        var title = Console.ReadLine();
        var description = Console.ReadLine();
        var v = new TaskToDo
        {
            Description = title,
            Title = description
        };
        _tasks.Add(v);
    }
}
