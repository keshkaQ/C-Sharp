﻿//// свой класс Logger
//public class FileLogger (string filePath)
//{
//    private void Log(string message)
//    {
//        using var streamWriter = new StreamWriter(filePath,true);
//        string logMessage = $"{DateTime.Now}: {message}";
//        streamWriter.WriteLine(logMessage);
//    }
//    public void LogError(string message)
//    {
//        Log($"ERROR: {message}");
//    }
//    public void LogWarning(string message)
//    {
//        Log($"WARNING: {message}");
//    }
//    public void LogInfo(string message)
//    {
//        Log($"INFO: {message}");
//    }
//}