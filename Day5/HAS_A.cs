using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class Subject
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public int Duration { get; set; }
        
        public Subject()
        {
            
        }

        public Subject(int Code, string Name, int Duration)
        {
            this.Code = Code;
            this.Name = Name;
            this.Duration = Duration;
        }

        public override string ToString()
        {
            return $"{Code}-{Name}-{Duration}\n";
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Subject[] Subjects { get; set; }

        public Student()
        {
        }

        public Student(int Id, string Name, int Age, Subject[] Subjects)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.Subjects = Subjects;
        }

        public override string ToString()
        {
            string text = $"{Id}-{Name}-{Age}\n";
            for (int i=0; i<Subjects.Length; i++) {
                text += Subjects[i].ToString();
            }

            return text;
        }
    }
}
