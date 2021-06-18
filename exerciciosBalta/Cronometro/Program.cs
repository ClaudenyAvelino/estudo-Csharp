using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Start(10);
        }
            static void Start(int time){
            // System.Console.WriteLine("Iforme o tempo :");
            // int time = int.Parse(Console.ReadLine());

            int currentTime = 0;
            while (currentTime != time)
            {
                System.Console.Clear();
                currentTime++;
                System.Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }    
        }
    }
}
