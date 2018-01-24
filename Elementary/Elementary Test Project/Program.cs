using Elementary;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using Elementary.Forms;

namespace Elementary_Test_Project
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            FilterTest();
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

        private static void FilterTest()
        {
            FilterCollection fc = new FilterCollection(
                new FilterItem("EXE File", "*.exe"), 
                new FilterItem("DLL File", "*.dll"), 
                new FilterItem("Image Files", "*.jpg", "*.png", "*.bmp", "*.gif")
            );

            OpenFileDialog ofd = new OpenFileDialog {Filter = fc.Filter};
            ofd.ShowDialog();
        }
    }
}