using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Start");
            new Thread(() =>
            {
                while (true)
                {
                    Console.WriteLine("Hello!");
                    Thread.Sleep(1000);
                }
            }).Start();
            Console.WriteLine("End");*/

            /*Process process = new Process();
            process.StartInfo = new ProcessStartInfo("notepad");
            process.Start();

            Thread.Sleep(5000);

            process.Kill();*/

            /*Process process = new Process();
            process.StartInfo = new ProcessStartInfo("calc");
            process.Start();

            Thread.Sleep(5000);

            if (!process.HasExited)
            {
                process.Kill();
            }
            else
            {
                process =
                    Process.GetProcessesByName("Calculator")[0];
                Console.WriteLine(process.Id);
                process.Kill();
            }*/

            Process process = new Process();
            process.StartInfo = new ProcessStartInfo("CPPConsoleApp.exe");
            process.Start();

            while (!process.HasExited)
            {
                Thread.Sleep(500);
            }

            Console.WriteLine(process.ExitCode);
        }
    }
}
