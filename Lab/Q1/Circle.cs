using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Q1
{
    public class Circle : IShape
    {
        public double Redius { get; set; }

        public Circle(){ }

        public Circle(double Redius)
        {
            this.Redius = Redius;
        }

        public double GetArea()
        {
            return Math.PI * Redius * Redius;
        }

        public string GetInfo()
        {
            return $"Redius = {Redius}, Area = {GetArea()}";
        }

        public override string ToString()
        {
            return GetInfo();
        }
    }
}
