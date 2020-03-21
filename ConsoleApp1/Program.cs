using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 5;
            Triangle[] conclusion = new Triangle[N];
            double averagesquare = 0;
            for (int i = 0; i < N; i++)
            {
                conclusion[i] = new Triangle();
                conclusion[i].High();
                conclusion[i].Perimeter();
                conclusion[i].Square();
                Console.WriteLine("-------------------------------------");
                averagesquare += conclusion[i].square;
            }
            averagesquare /= N;
            Console.WriteLine($"Average Square = {averagesquare}");
            for (int i = 0; i < N; i++)
            {
                if (conclusion[i].square > averagesquare)
                    Console.WriteLine($"Bigger square then Average Square = {conclusion[i].square}");
            }

        }
    }
}
