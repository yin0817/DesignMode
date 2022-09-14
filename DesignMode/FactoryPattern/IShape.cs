using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal interface IShape
    {
        void Draw();
    }

    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle.Draw");
        }
    }
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Square.Draw");
        }
    }
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle.Draw");
        }
    }
}
