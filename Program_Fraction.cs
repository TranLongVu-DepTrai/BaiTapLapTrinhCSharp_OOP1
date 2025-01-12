// File: Program.cs
using System;
using OOP_HomeWork_4;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_HomeWork_4
{
    class Program_Fraction
    {
        static void Main(string[] args)
        {
          
            Console.Write("Nhap tu so cua phan so thu nhat: ");
            int numerator1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so cua phan so thu nhat: ");
            int denominator1 = int.Parse(Console.ReadLine());

            Fraction fraction1 = new Fraction(numerator1, denominator1);

        
            Console.Write("Nhap tu so cua phan so thu hai: ");
            int numerator2 = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so cua phan so thu hai: ");
            int denominator2 = int.Parse(Console.ReadLine());

            Fraction fraction2 = new Fraction(numerator2, denominator2);

          
            Console.WriteLine($"Phan so thu nhat: {fraction1}");
            Console.WriteLine($"Phan so thu hai: {fraction2}");

            Fraction sum = fraction1 + fraction2;
            Console.WriteLine($"Tong hai phan so: {sum}");

            Fraction difference = fraction1 - fraction2;
            Console.WriteLine($"Hieu hai phan so: {difference}");

            Fraction product = fraction1 * fraction2;
            Console.WriteLine($"Tich hai phan so: {product}");

            Fraction quotient = fraction1 / fraction2;
            Console.WriteLine($"Thuong hai phan so: {quotient}");

          
            Console.WriteLine($"Phan so thu nhat duoi dang so thap phan: {fraction1.ToDecimal()}");
            Console.WriteLine($"Phan so thu hai duoi dang so thap phan: {fraction2.ToDecimal()}");
        }
    }
}
