using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class ShapeFactory
    {
        public static IShape? GetShape(string shapeType)
        {
            switch (shapeType)
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
