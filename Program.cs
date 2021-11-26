using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n---Tabuada---\n");

            Console.Write("Me informe o número no qual você deseja saber a tabuada (de 1 a 10): ");
            double multiplicado = Convert.ToDouble(Console.ReadLine());

            double multiplicando = 1;

            while (multiplicando <= 10)
            {
                
            double resultado = multiplicado * multiplicando;
            Console.WriteLine($"{multiplicando} x {multiplicado} = {resultado}");
            multiplicando = multiplicando + 1;

    

            }


        }
    }
}
