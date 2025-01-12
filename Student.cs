using System;
using OOP_HomeWork_2;

namespace OOP_HomeWork_2
{
    // Lớp Student kế thừa từ lớp Person
    public class Student : Person
    {
        // Trường
        private double gpa;

        // Thuộc tính
        public double Gpa
        {
            get { return gpa; }
            set { gpa = value; }
        }

        // Constructor không tham số (mặc định)
        public Student()
        {
            // Khởi tạo các giá trị mặc định nếu cần
            Gpa = 0.0;
        }

        // Phương thức hiển thị thông tin Student
        public void DisplayStudent()
        {
            DisplayPerson(); // Gọi phương thức hiển thị của lớp Person
            Console.WriteLine("GPA: " + Gpa);
        }

        // Phương thức nhập thông tin cho Student
        public new void Input()
        {
            base.Input(); // Gọi phương thức nhập của lớp Person
            Console.Write("Nhap GPA: ");
            Gpa = double.Parse(Console.ReadLine());
        }

        // Phương thức khởi tạo có tham số là đối tượng Student
        public Student(Student student)
        {
            this.Name = student.Name;
            this.Age = student.Age;
            this.Gpa = student.Gpa;
        }
    }
}
