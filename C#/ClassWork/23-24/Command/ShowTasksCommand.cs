using C_.ClassWork._23_24.Command;

public class ShowTasksCommand(List<TaskToDo> tasks, Action<string> show) : ITaskCommand
{
    public void Execute()
    {
        for (int i = 0; i < tasks.Count; i++)
        {
            show.Invoke($"{i + 1}: {tasks[i]}");
        }
    }
}