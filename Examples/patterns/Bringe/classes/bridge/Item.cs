using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bringe
{
    class Item : ItemBase
    {
        public override void GetCurrent()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            base.GetCurrent();
            Console.WriteLine("done!");
        }
    }
}
