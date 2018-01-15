using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ComponentDecorator : IComponent
    {
        private IComponent _component;

        public ComponentDecorator(IComponent compnent)
        {
            _component = compnent;
        }

        public string Text { get; set; }

        public virtual void Print()
        {
            _component.Print();
        }
    }
}
