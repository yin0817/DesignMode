using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    abstract class AbstractFactory
    {
        public abstract IColor? GetColor(string color);
        public abstract IShape? GetShape(string shape);
    }
}
