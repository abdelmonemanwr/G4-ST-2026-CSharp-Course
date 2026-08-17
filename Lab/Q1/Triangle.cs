using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Q1
{
    public class Triangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        
        public Triangle()
        {
            
        }

        public Triangle(double Base, double Height)
        {
            this.Base = Base;
            this.Height = Height;
        }

        public double GetArea()
        {
            return 0.5 * Base * Height;
        }

        public string GetInfo()
        {
            return $"Base = {Base}, Height = {Height}, Area = {GetArea()}";
        }

        public override string ToString()
        {
            return GetInfo();
        }
    }
}
