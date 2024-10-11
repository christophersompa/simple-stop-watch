using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_stop_watch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my stopwatch application:");
            
            Stopwatch stopwatch = new Stopwatch();

            bool isRunning = true;

            while (isRunning == true) {


                Console.WriteLine("Action: 1. Start | 2. Stop | 3. Reset | 4. Exit");

                string action = Console.ReadLine();

                if (action == "Start" || action == "1")
                {
                    stopwatch.Start();
                    Console.WriteLine("Stopwatch has started!");
                }
                else if (action == "Stop" || action == "2")
                {
                    stopwatch.Stop();

                    Console.WriteLine($"Time elapsed: {stopwatch.Elapsed}");
                }
                else if (action == "Reset" || action == "3")
                {
                    stopwatch.Reset();
                    Console.WriteLine("Stopwatch has been reset!");
                }
                else if (action == "Exit" || action == "4")
                {
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("Incorrect input!");
                }
            }
            Console.ReadLine();
        }
    }
}
