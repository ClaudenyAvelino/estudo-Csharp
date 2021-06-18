using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
            static void Menu(){
                System.Console.Clear();
                System.Console.WriteLine("S = Segundo");
                System.Console.WriteLine("M = Minuto");
                System.Console.WriteLine("0 = Sair");
                System.Console.WriteLine("Quanto tempo deseja contar ?");

                string data = Console.ReadLine().ToLower();
                char type = char.Parse(data.Substring(data.Length - 1, 1));
                int time = int.Parse(data.Substring(0, data.Length - 1));

                System.Console.WriteLine(type);
                System.Console.WriteLine(time);              
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
            System.Console.Clear();
            System.Console.WriteLine("Cronometro finalizado");
            Thread.Sleep(2500);
        }
    }
}
