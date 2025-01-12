using System;
using OOP_HomeWork_2;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Input();
            Console.WriteLine("\nThông tin sinh viên:");
            student.DisplayStudent();

            Console.ReadLine(); // Để giữ cửa sổ console mở
        }
    }
}
