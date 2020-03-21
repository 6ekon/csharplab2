using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Triangle
    {
        double length, high, perimeter;
        public double square;
        Random r = new Random();
        public Triangle()
        {
            length = r.Next(0, 20);
        }
        public void High()
        {
            high = (length * Math.Sqrt(3)) / 2;
            Console.WriteLine($"High and bisector = {high}");
        }
        public void Perimeter()
        {
            perimeter = length * 3;
            Console.WriteLine($"Perimeter = {perimeter}");
        }
        public void Square()
        {
            square = (length * high) / 2;
            Console.WriteLine($"Square = {square}");
        }

    }
}
