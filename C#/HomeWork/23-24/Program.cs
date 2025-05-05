//using C_.ClassWork._23_24.Command;
//using NLog;
//using NLog.Config;
//using NLog.Targets;
//using System.Threading.Tasks;


//var loggingConfiguration = new LoggingConfiguration();
//var fileTarget = new FileTarget
//{
//    FileName = "C:\\Users\\TitanPC\\Desktop\\log.txt",
//    Layout = @"${longdate}|${level:uppercase=true}|${message} ${exception}"
//};
//loggingConfiguration.AddRule(LogLevel.Info, LogLevel.Error, fileTarget);
//LogManager.Configuration = loggingConfiguration;
//var logger = LogManager.GetCurrentClassLogger();

//var tasks = new List<TaskToDo>();
////var fileLogger = new FileLogger("C:\\Users\\TitanPC\\Desktop\\log.txt");

//var command = "-1";
//while (command != "6")
//{
//    DisplayMenu();
//    command = Console.ReadLine();
//    try
//    {
//        switch (command)
//        {
//            case "1":
//                new AddTaskCommand(tasks,logger).Execute();
//                break;
//            case "2":
//                new RemoveTaskCommand(tasks,logger).Execute();
//                break;
//            case "3":
//                new UpdateTaskCommand(tasks, logger).Execute();
//                break;
//            case "4":
//                new ShowTasksCommand(tasks).Execute();
//                break;
//            case "5":
//                new ChangeStatusTaskCommand(tasks, logger).Execute();
//                break;
//            case "6":
//                Console.WriteLine("Выход");
//                break;
//            default:
//                Console.WriteLine("Неизвестная команда. Попробуйте снова.");
//                return;
//        }
//    }
//    catch (Exception ex)
//    {
//        logger.Error(ex, "Ошибка при выполнении команды");
//        Console.WriteLine($"Произошла ошибка: {ex.Message}");
//    }
//}
//void DisplayMenu()
//{
//    Console.WriteLine("\nВыберите действие:");
//    Console.WriteLine("1. Добавить задачу");
//    Console.WriteLine("2. Удалить задачу");
//    Console.WriteLine("3. Обновить задачу");
//    Console.WriteLine("4. Показать задачи");
//    Console.WriteLine("5. Изменить статус задачи");
//    Console.WriteLine("6. Выход");
//}