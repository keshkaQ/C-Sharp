using C_.ClassWork._23_24.Command;

public class ShowTasksCommand(List<TaskToDo> tasks) : ITaskCommand
{
    public void Execute()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Список задач пуст");
            return;
        }
        Console.WriteLine($"Активные задачи ({tasks.Count()}): ");

        var activeTasks = tasks.Select((task, index) => new { Task = task, Index = index + 1 })
            .Where(x => x.Task.GetTextComplete() == "Активна").ToList();

        foreach (var item in activeTasks)
        {
            Console.WriteLine($"{item.Index}. {item.Task}");
        }
    }
}