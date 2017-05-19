using Elementary;
using System;
using System.Diagnostics;
using System.Threading;
namespace Elementary_Test_Project
{
    internal static class Program
    {
        private static void Main()
        {
            LogTest();
        }

        private static void LogTest()
        {
            Logman.LogOutput = LogOutput.Console | LogOutput.File;
            Logman.FileOutputPath = ".\\log.txt";
            Logman.Log("Test");
            Thread.Sleep(2000);
            Logman.Log("This is another test");
            Thread.Sleep(1000);
            Logman.Log("This is an information message", LogLevel.Information);
            Thread.Sleep(1000);
            Logman.Log("This is a warning message", LogLevel.Warning);
            Thread.Sleep(1000);
            Logman.Log("This is an error message", LogLevel.Error);
            Console.ReadKey();
            Process.Start(".\\log.txt");
        }
    }
}