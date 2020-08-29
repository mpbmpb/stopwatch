using System;
using System.Threading;

namespace stopwatch
{
    static class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            void Demo(int ms)
            {
                Console.WriteLine("stopwatch start...");
                stopwatch.Start();
                Thread.Sleep(ms);
                var duration = stopwatch.Stop().ToString();

                Console.WriteLine($"Duration: {duration}");
                Console.WriteLine();
            }

            Demo(825);
            Demo(1672);

            try
            {
                Console.WriteLine("trying to stop stopwatch...");
                stopwatch.Stop();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }

            try
            {
                Console.WriteLine("stopwatch start...");
                stopwatch.Start();
                Console.WriteLine("trying to start stopwatch again...");
                stopwatch.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
