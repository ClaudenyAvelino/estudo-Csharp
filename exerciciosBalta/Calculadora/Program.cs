using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

          }      
        static void Menu(){
            Console.Clear();
            Console.WriteLine("O que deseja fazer ?? ");
            System.Console.WriteLine("1 - Soma");
            System.Console.WriteLine("2 - Subtração");
            System.Console.WriteLine("3 - Divisão");
            System.Console.WriteLine("4 - Multiplicação");
            System.Console.WriteLine("5 - Sair");
            System.Console.WriteLine("--------------------");
            System.Console.WriteLine("Selecione a opção:");
            short res = short.Parse(Console.ReadLine());

            switch (res){
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default : Menu(); break;
                               
            }
        }

        static void Soma(){
             System.Console.Clear();
             Console.WriteLine("Primeiro valor ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1+v2;
            
            Console.WriteLine("A soma é :"+resultado);
           // System.Console.WriteLine($"A soma é {resultado:F2}:");
           Console.ReadKey();
           Menu();
            }

              static void Subtracao(){
                Console.Clear();
                Console.WriteLine("Primeiro valor ");
                float V1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo valor ");
                float V2 = float.Parse(Console.ReadLine());

                float resultado = V1-V2;

                Console.WriteLine($"O resultado é {resultado}");
                Console.ReadKey();
                Menu();
            }
             static void Divisao(){
                    Console.Clear();

                    Console.Clear();
                Console.WriteLine("Primeiro valor ");
                float V1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo valor ");
                float V2 = float.Parse(Console.ReadLine());

                float resultado = V1/V2;

                Console.WriteLine($"O resultado é {resultado}");

                    Console.ReadKey();
                    Menu();
                }
                 static void Multiplicacao(){
                    Console.Clear();

                    Console.Clear();
                Console.WriteLine("Primeiro valor ");
                float V1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Segundo valor ");
                float V2 = float.Parse(Console.ReadLine());

                float resultado = V1*V2;

                Console.WriteLine($"O resultado é {resultado}");

                    Console.ReadKey();
                    Menu();
                }
    }
}
