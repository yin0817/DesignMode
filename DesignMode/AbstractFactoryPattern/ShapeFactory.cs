using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class ShapeFactory : AbstractFactory
    {
        public override IColor? GetColor(string color)
        {
            return null;
        }

        public override IShape? GetShape(string shape)
        {
            switch (shape)
            {
                case "Rectangle":
                    return new Rectangle();
                case "Square":
                    return new Square();
                case "Circle":
                    return new Circle();
                default:
                    break;
            }
            return null;
        }
    }
}
