using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    //class Student : IComparable, IDisposable
    class Student : IComparable<Student>, IDisposable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Student()
        {

        }
        public Student(int Id, string Name, int Age)
        {
            this.Id = Id;
            this.Age = Age;
            this.Name = Name;
        }
        public override string ToString()
        {
            return $"{Id}-{Name}-{Age}";
        }

        //// non generic method
        //public int CompareTo(object? obj)
        //{
        //    Student s = obj as Student;
        //    //if (Id > s.Id) return 1;
        //    //else if (Id == s.Id) return 0;
        //    //else return -1;
        //    return Id.CompareTo(s.Id);
        //    //return Age.CompareTo(s.Age);
        //}

        // generic
        public int CompareTo(Student? s)
        {
            return Id.CompareTo(s.Id);
        }

        ~Student()
        {
            Console.WriteLine("destructor is invoked");
        }

        public void Dispose()
        {
            Console.WriteLine("object disposed");
        }

    }
}
