
using System;
using OOP_HomeWork_1;

namespace OOP_HomeWork_1
{
   
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Nhap so mat cua xxc xac: ");
            int soMat = int.Parse(Console.ReadLine());


            XucXac Xucxac = new XucXac(soMat);

          
            Console.WriteLine($"Kết quả của lần tung xúc xắc: {Xucxac.DoXucXac()}");
        }
    }
}
