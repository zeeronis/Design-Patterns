using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composite
{
    class Map : IMapCompnent
    {
        private IList<IMapCompnent> _mapComponents = new List<IMapCompnent>();
        public string Title { get; set; }

        public void AddCompnent(IMapCompnent component)
        {
            _mapComponents.Add(component);
        }
        public void Draw()
        {
            Console.WriteLine(Title);
            foreach (var mapComponent in _mapComponents)
            {
                mapComponent.Draw();
            }
        }

        public IMapCompnent Find(string title)
        {
            if (title.Equals(Title, StringComparison.Ordinal))
            {
                return this;
            }

            foreach (var mapComponent in _mapComponents)
            {
                var compnent = mapComponent.Find(title);
                if (compnent != null)
                {
                    return compnent;
                }
            }

            throw new ArgumentOutOfRangeException("title");
        }
    }
}
