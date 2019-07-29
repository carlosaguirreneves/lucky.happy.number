using System;
using NumberAwesome.Console.Numbers;

namespace LuckAndHappyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Digite um número: ");

            long numero = 0;
            string numeroLido = Console.ReadLine();

            Console.WriteLine("");

            if (long.TryParse(numeroLido, out numero))
            {
                Console.WriteLine("Using Type ArrayLuckyNumber:");
                var start = DateTime.Now.TimeOfDay;

                LuckyNumber luckyNumber = new ArrayLuckyNumber(numero);
                Console.WriteLine(luckyNumber.IsLucky() ? "É um número sortudo": "Não é um número sortudo?");

                var finish = DateTime.Now.TimeOfDay;
                Console.WriteLine("Executado em " + finish.Subtract(start).Milliseconds + " milissegundo");

                Console.WriteLine("");
                Console.WriteLine("Using Type ListLuckyNumber:");
                start = DateTime.Now.TimeOfDay;

                luckyNumber = new ListLuckyNumber(numero);
                Console.WriteLine(luckyNumber.IsLucky() ? "É um número sortudo": "Não é um número sortudo?");

                finish = DateTime.Now.TimeOfDay;
                Console.WriteLine("Executado em " + finish.Subtract(start).Milliseconds + " milissegundo ");
                
                Console.WriteLine("");
                var happyNumber = new HappyNumber(numero);
                Console.WriteLine(happyNumber.IsHappy() ? "É um número feliz": "Não é um número feliz");

                Console.WriteLine("Pressione qualquer tecla para terminar.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Valor informado não é um número.");
                Console.WriteLine("");
            }            
        }
    }
}
