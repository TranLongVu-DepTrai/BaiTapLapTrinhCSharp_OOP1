using System;
using OOP_HomeWork_2;

namespace OOP_HomeWork_2
{
    // Lớp Person
    public class Person
    {
        // Các trường
        private int age;
        private string name;

        // Các thuộc tính
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Phương thức hiển thị thông tin Person
        public void DisplayPerson()
        {
            Console.WriteLine("Tên: " + Name);
            Console.WriteLine("Tuổi: " + Age);
        }

        public void Input()
        {
            Console.Write("Nhap ten: ");
            Name = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            Age = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"Tên: {Name}, Tuổi: {Age}";
        }
    }
}
