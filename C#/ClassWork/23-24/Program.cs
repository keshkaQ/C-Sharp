//using C_.ClassWork._23_24.Command;
//using NLog;
//using NLog.Config;
//using NLog.Targets;

//var loggingConfiguration = new LoggingConfiguration();

//var fileTarget = new FileTarget
//{
//    FileName = "path",
//    Layout = @"${longdate}|${level:uppercase=true}|${message} ${exception}"
//};

//loggingConfiguration.AddRule(LogLevel.Info, LogLevel.Error, fileTarget);

//LogManager.Configuration = loggingConfiguration;

//var logger = LogManager.GetCurrentClassLogger();
//logger.Info("Dfffsfsdf");
//logger.Error("sdasdasdds");

//var task = new List<TaskToDo>();
//var fileLogger = new FileLogger("path");


//var commandByNumberCommand = new Dictionary<string, ITaskCommand>();
//commandByNumberCommand.Add("1", new AddTaskCommand(task));
//commandByNumberCommand.Add("2", new RemoveTaskCommand(task));
//commandByNumberCommand.Add("3", new UpdateTaskCommand(task,fileLogger));
//commandByNumberCommand.Add("4", new ShowTasksCommand(task, Console.WriteLine));
//commandByNumberCommand.Add("5", new ChangeStatusTaskCommand(task,fileLogger));
//string numberCommand = "-1";

//do
//{
//    numberCommand = Console.ReadLine();
//    if (commandByNumberCommand.TryGetValue(numberCommand, out ITaskCommand command))
//    {

//        command.Execute();
//    }

//} while (numberCommand != "6");