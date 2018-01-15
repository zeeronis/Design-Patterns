using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composite
{
    class ElementMapCompnent : IMapCompnent
    {
        public string Title { get; set; }
        public void Draw()
        {
            Console.WriteLine();
        }
        public IMapCompnent Find(string title)
        {
            return string.Equals(title, Title, StringComparison.Ordinal) ? this : null;
        }
    }
}
