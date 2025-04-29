using C_.ClassWork._23_24.Command;

public class RemoveTaskCommand(List<TaskToDo> tasks) : ITaskCommand
{
    public void Execute()
    {
        var numberTask = int.Parse(Console.ReadLine());
        if (tasks.Count >= numberTask)
        {
            tasks.RemoveAt(numberTask - 1);

        }
        else
        {


        }

    }
}