using System;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static void Start(){

        System.Console.WriteLine("Iforme o tempo :");
        int time = int.Parse(Console.ReadLine());
        int currentTime = 0;
        while (currentTime != time)
        {
            currentTime++;
            System.Console.WriteLine(currentTime);
        }    
        }
    }
}
