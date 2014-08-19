using System;
using System.Threading;

namespace MyWebJob
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Working");
                Thread.Sleep(60*1000);
            }
        }
    }
}
