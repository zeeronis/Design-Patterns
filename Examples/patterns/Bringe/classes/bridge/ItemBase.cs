using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bringe
{
    class ItemBase
    {
        public IdataObject<string> DataObject { get; set; }
        public virtual void Next()
        {
            DataObject.NextItem();
        }

        public virtual void Prev()
        {
            DataObject.PrevItem();
        }

        public virtual void Add(string item)
        {
            DataObject.AddItem(item);
        }

        public virtual void GetCurrent()
        {
            var currentItem = DataObject.GetCurrentItem();
            Console.WriteLine(currentItem);
        }
    }
}
