using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent comp1 = new Compnent() { Text = "mm" };
            comp1.Print();

            IComponent comp2 = new ComponentWithBrackets(comp1);
            comp2.Print();

            IComponent comp3 = new ComponentWithBrackets(comp1);
            comp3.Print();

            Console.Read();
        }
    }
}
