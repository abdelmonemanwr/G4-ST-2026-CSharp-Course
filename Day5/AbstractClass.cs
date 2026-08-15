using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual void Show()
        {
            Console.WriteLine("jhjh");
        }

        public abstract void Display();
    }

    class Teacher : Person
    {

        public string Degree { get; set; }

        public override void Display()
        {
            Console.WriteLine($"{Id}-{Name}-{Email}");
        }

        //public abstract void Print();

        public sealed override void Show()
        {
            base.Show();
        }

    }
}
