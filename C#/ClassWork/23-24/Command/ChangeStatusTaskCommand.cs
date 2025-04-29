using C_.ClassWork._23_24.Command;

public class ChangeStatusTaskCommand(List<TaskToDo> tasks, FileLogger fileLogger) : ITaskCommand
{
    public void Execute()
    {
        var numberTask = int.Parse(Console.ReadLine());
        fileLogger.LogInfo($"получаю запись задачи по  номеру {numberTask}");
        if (tasks.Count >= numberTask && numberTask > 0)
        {
            var mytask = tasks[numberTask - 1];
            mytask.ChangeComplete();
        }
        else
        {
            fileLogger.LogWarning($"Попытка обратиться к несуществующему номеру {numberTask}");
        }

    }

}