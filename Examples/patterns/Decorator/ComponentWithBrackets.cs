﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ComponentWithBrackets : ComponentDecorator
    {
        public ComponentWithBrackets(IComponent compnent) : base(compnent)
        {
        }

        public override void Print()
        {
            Console.WriteLine("\"");
            base.Print();
            Console.WriteLine("\"");
        }
    }
}
