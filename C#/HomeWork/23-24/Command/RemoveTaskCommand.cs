using C_.ClassWork._23_24.Command;
using NLog;

public class RemoveTaskCommand(List<TaskToDo> tasks, Logger fileLogger) : ITaskCommand
{
    public void Execute()
    {
        try
        {
            Console.Write("Введите номер задачи, которую хотите удалить: ");
            if (!int.TryParse(Console.ReadLine(), out var numberTask))
            {
                fileLogger.Warn("Введен некорректный номер задачи");
                Console.WriteLine("Ошибка: номер задачи должен быть целым числом");
                return;
            }

            fileLogger.Info($"Попытка удалить задачу с номером {numberTask}");

            if (numberTask <= 0 || numberTask > tasks.Count)
            {
                fileLogger.Warn($"Попытка удалить несуществующую задачу (введен номер {numberTask}, всего задач: {tasks.Count})");
                Console.WriteLine($"Ошибка: задача с номером {numberTask} не существует");
                return;
            }

            var taskToRemove = tasks[numberTask - 1];
            tasks.RemoveAt(numberTask - 1);

            Console.WriteLine($"Задача '{taskToRemove.Title}' (номер {numberTask}) успешно удалена");
            fileLogger.Info($"Задача '{taskToRemove.Title}' (номер {numberTask}) удалена из списка");
        }
        catch (Exception ex)
        {
            fileLogger.Error(ex, "Ошибка при удалении задачи");
            Console.WriteLine("Произошла ошибка при удалении задачи");
            throw; 
        }
    }
}