using Elementary;
using System;
using System.Threading;

namespace Elementary_Test_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Logman.LogOptions = LogOptions.Console | LogOptions.ImmediateWindow | LogOptions.File;
            Logman.Log("Test");
            Thread.Sleep(1000);
            Logman.Log("This is another test");
            Console.ReadKey();
        }
    }
}