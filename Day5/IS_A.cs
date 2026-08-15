using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Parent
    {
        int y;
        public int X { get; set; }
        public Parent()
        {
            y = 0;
        }
        public Parent(int X)
        {
            this.X = X;
        }

        public virtual void Show()
        {
            Console.WriteLine($"show: x = {X}");
        }

        public override string ToString()
        {
            return $"x={X}";
        }
    }

    class Child : Parent
    {
        public int Z { get; set; }      // X, y, Show     Dai, Ebraam

        //public new string X { get; set; }
        public Child()
        {
            
        }

        public Child(int x, int z): base(x)
        {
            Z = z;
        }

        public sealed override void Show()
        {
            base.Show();
            Console.WriteLine($"show: z = {Z}");
        }

        public override string ToString()
        {
            return base.ToString() + $" z={Z}";
            //return $"x={X}, z={Z}";
        }

    }

    class SubChild: Child
    {
        public int A { get; set; }

        public SubChild(int x, int z, int a) : base(x, z)
        {
            A = a;
        }

        public new void show()
        {
            Console.WriteLine($"x={X}, z={Z}, a={A}");
        }
    }
}
