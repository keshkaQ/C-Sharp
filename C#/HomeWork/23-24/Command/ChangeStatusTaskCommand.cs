using C_.ClassWork._23_24.Command;
using NLog;

public class ChangeStatusTaskCommand(List<TaskToDo> tasks, Logger fileLogger) : ITaskCommand
{
    public void Execute()
    {
        try
        {
            Console.Write("Введите номер задачи, статус которой нужно изменить: ");
            if (!int.TryParse(Console.ReadLine(), out var numberTask))
            {
                fileLogger.Warn("Введен некорректный номер задачи при обновлении статуса");
                Console.WriteLine("Ошибка: номер задачи должен быть целым числом");
                return;
            }

            fileLogger.Info($"Получаю запись задачи по номеру {numberTask}");

            if (numberTask <= 0 || numberTask > tasks.Count)
            {
                fileLogger.Warn($"Попытка изменить задачу с номером {numberTask}");
                Console.WriteLine($"Ошибка: задача с номером {numberTask} не существует");
                return;
            }

            var myTask = tasks[numberTask - 1];
            myTask.ChangeComplete();

            Console.WriteLine($"Статус задачи '{myTask.Title}' успешно обновлен");
            fileLogger.Info($"Статус задачи с названием '{myTask.Title}' был изменен");
        }
        catch (Exception ex)
        {
            fileLogger.Error(ex, "Ошибка при изменении статуса задачи");
            Console.WriteLine("Произошла ошибка при изменении статуса задачи");
            throw; 
        }
    }
}