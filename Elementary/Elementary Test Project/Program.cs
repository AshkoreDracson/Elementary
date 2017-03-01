using Elementary;
using System;
using System.Threading;
namespace Elementary_Test_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Logman.LogOutput = LogOutput.Console | LogOutput.ImmediateWindow | LogOutput.File;
            Logman.FileOutputPath = "./log.txt";
            Logman.Log("Test");
            Thread.Sleep(2000);
            Logman.Log("This is another test");
            Console.ReadKey();
        }
    }
}