using System;

namespace WHMCS.NET.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting...");

            new Test().Run().Wait();
        }
    }
}