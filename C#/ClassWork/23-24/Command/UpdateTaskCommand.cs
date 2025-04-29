using C_.ClassWork._23_24.Command;

public class UpdateTaskCommand(List<TaskToDo> tasks,FileLogger fileLogger) : ITaskCommand
{
    public void Execute()
    {
        try
        {
            var numberTask = int.Parse(Console.ReadLine());
            if (tasks.Count >= numberTask)
            {
                var task = tasks[numberTask - 1];

                var title = Console.ReadLine();
                var description = Console.ReadLine();
                task.Title = title;
                task.Description = description;
            }
        }
        catch (Exception ex)
        {
            fileLogger.LogError(ex.Message);
        }
   

    }
}