using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    internal interface IColor
    {
        void Fill();
    }

    public class Red : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Red.Fill");
        }
    }
    public class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Green.Fill");
        }
    }
    public class Blue : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Blue.Fill");
        }
    }
}
