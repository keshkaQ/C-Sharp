using C_.ClassWork._23_24.Command;
using NLog;

public class UpdateTaskCommand(List<TaskToDo> tasks, Logger fileLogger) : ITaskCommand
{
    public void Execute()
    {
        try
        {
            Console.Write("Введите номер задачи, которую нужно изменить: ");
            if (!int.TryParse(Console.ReadLine(), out var numberTask))
            {
                fileLogger.Warn("Введен некорректный номер задачи при обновлении");
                Console.WriteLine("Некорректный номер задачи");
                return;
            }

            if (numberTask <= 0 || numberTask > tasks.Count)
            {
                fileLogger.Warn($"Попытка обновить несуществующую задачу (введен номер {numberTask}, всего задач: {tasks.Count})");
                Console.WriteLine($"Задачи с номером {numberTask} не существует");
                return;
            }

            var task = tasks[numberTask - 1];
            Console.Write("Введите новый заголовок: ");
            task.Title = Console.ReadLine();

            Console.Write("Введите новое описание: ");
            task.Description = Console.ReadLine();

            Console.WriteLine($"Задача успешно обновлена");
            fileLogger.Info($"Задача была обновлена");
        }
        catch (Exception ex)
        {
            fileLogger.Error(ex, "Ошибка при обновлении задачи");
            Console.WriteLine($"Ошибка при обновлении задачи: {ex.Message}");
            throw; 
        }
    }
}