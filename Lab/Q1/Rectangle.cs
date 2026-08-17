using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Q1
{
    internal class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle() { }

        public Rectangle(double Width, double Height) 
        {
            this.Width = Width;
            this.Height = Height;
        }

        public double GetArea()
        {
            return Width * Height;
        }

        public string GetInfo()
        {
            return $"Width = {Width}, Height = {Height}, Area = {GetArea()}";
        }

        public override string ToString()
        {
            return GetInfo();
        }
    }
}
