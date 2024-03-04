using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    internal class Timer
    {
        public Timer()
        {
            Console.WriteLine("Welcome to Pomodoro Timer!");

            while (true)
            {
                Console.WriteLine("Press Enter to start a Pomodoro Timer...");
                Console.ReadLine();

                Console.WriteLine("Pomodoro session started!");
                TimeSpan duration = TimeSpan.FromMinutes(25);
                
                while (duration.TotalSeconds > 0)
                {
                    Console.WriteLine($"Time Left: {duration:mm\\:ss}");
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                    duration = duration.Subtract(TimeSpan.FromSeconds(1));
                }

                
                Console.WriteLine("Pomodoro session completed!");
                int con = 0;
                while (con < 5)
                {
                    Console.Beep();
                    con++;
                }
                Console.WriteLine("Take a short break...\n");
                Thread.Sleep(TimeSpan.FromMinutes(5));
                
                Console.WriteLine("Press Enter to start the next Pomodoro session or Press q or Q to quit...");
                var key = Console.ReadLine();

                    if (key.ToLower() == "q")
                    {
                        break;
                    }
            }
        }
    }
}
