using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composite
{
    interface IMapCompnent
    {
        string Title { get; set; }
        void Draw();
        IMapCompnent Find(string title);
    }
}
