
using System;
using OOP_HomeWork_4;
namespace OOP_HomeWork_4
{
    public class Fraction
    {

        public int Numerator { get; set; }
        public int Denominator { get; set; }


        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
            Simplify();
        }


        public void Simplify()
        {
            int gcd = GCD(Numerator, Denominator);
            Numerator /= gcd;
            Denominator /= gcd;
        }


        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }


        public static Fraction operator +(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            int denominator = a.Denominator * b.Denominator;
            return new Fraction(numerator, denominator);
        }


        public static Fraction operator -(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            int denominator = a.Denominator * b.Denominator;
            return new Fraction(numerator, denominator);
        }


        public static Fraction operator *(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Numerator;
            int denominator = a.Denominator * b.Denominator;
            return new Fraction(numerator, denominator);
        }


        public static Fraction operator /(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Denominator;
            int denominator = a.Denominator * b.Numerator;
            return new Fraction(numerator, denominator);
        }


        public override string ToString()
        {
            return $"({Numerator}/{Denominator})";
        }


        public string ToDecimal()
        {
            return (Numerator / (double)Denominator).ToString();
        }
    }
}
