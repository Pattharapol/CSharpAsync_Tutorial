using System;
using System.Diagnostics;

namespace AsyncCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Process.Start("notepad.exe");
            //Process.Start("notepad.exe", "C:\\tmp\\HelloWorld.txt");
            //Process.Start(@"C:\\Temp\\HelloWorld.txt");

            //var app = new Process
            //{
            //    StartInfo = {
            //        FileName = @"notepad.exe",
            //        Arguments = @"C:\\Temp\\HelloWorld.txt"
            //     }
            //};
            //app.Start();

            //app.PriorityClass = ProcessPriorityClass.RealTime;


            // KILL PROCESS
            try
            {
                var process = Process.GetProcesses();
                foreach (var p in process)
                {
                    if (p.ProcessName == "Hospital")
                    {
                        p.Kill();
                    }
                }
                Environment.Exit(0);
            }
            catch (Exception)
            {

            }
        }
    }
}
