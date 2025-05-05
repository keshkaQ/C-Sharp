using C_.ClassWork._23_24.Command;
using NLog;

public class AddTaskCommand(List<TaskToDo> _tasks, Logger fileLogger) : ITaskCommand
{
    public void Execute()
    {
        try
        {
            Console.Write("Введите название задачи: ");
            var title = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(title))
            {
                fileLogger.Warn("Попытка добавить задачу с пустым названием");
                Console.WriteLine("Ошибка: название задачи не может быть пустым");
                return;
            }

            Console.Write("Введите описание задачи: ");
            var description = Console.ReadLine();

            var newTask = new TaskToDo
            {
                Title = title,  
                Description = description
            };

            _tasks.Add(newTask);
            fileLogger.Info($"Задача с названием '{newTask.Title}' добавлена в журнал");
            Console.WriteLine($"Задача '{newTask.Title}' успешно добавлена");
        }
        catch (Exception ex) 
        {
            fileLogger.Error(ex, "Ошибка при добавлении задачи");
            Console.WriteLine("Произошла ошибка при добавлении задачи");
            throw; 
        }
    }
}