using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = new Map() { Title = "Minsk" };

            var serebranka = new Map() { Title = "Serebronks" };
            serebranka.AddCompnent(new ElementMapCompnent() { Title = "Rokossovsk" });

            city.AddCompnent(serebranka);
            city.Draw();

            Console.ReadKey();
        }
    }
}
