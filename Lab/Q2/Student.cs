using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Q2
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }

        public Student() { }
        public Student(int Id, string Name, string Email, int Age, double Grade)
        {
            this.Id = Id;
            this.Age = Age;
            this.Name = Name;
            this.Email = Email;
            this.Grade = Grade;
        }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, Email = {Email}, Age = {Age}, Grade = {Grade}";
        }
    }
}
