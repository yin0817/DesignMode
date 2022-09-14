using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal class ColorFactory : AbstractFactory
    {
        public override IColor? GetColor(string color)
        {
            switch (color)
            {
                case "Red":
                    return new Red();
                case "Green":
                    return new Green();
                case "Blue":
                    return new Blue();
                default:
                    break;
            }
            return null;
        }

        public override IShape? GetShape(string shape)
        {
            return null;
        }
    }
}
