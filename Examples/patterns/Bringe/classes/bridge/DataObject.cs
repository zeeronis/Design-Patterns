using System.Collections.Generic;

namespace Bringe
{
    class DataObject : IdataObject<string>
    {
        private IList<string> _list;
        private int _current;

        public DataObject()
        {
            _list = new List<string> { "asd", "asdss", "sdsd" };
        }


        public void NextItem()
        {
            if (_current < _list.Count -1)
            {
                _current++;
            }
        }

        public void PrevItem()
        {
            if (_current > 0)
            {
                _current--;
            }
        }
        public void AddItem(string item)
        {
            _list.Add(item);
        }
        public void deleteItem(string item)
        {
            _list.Remove(item);
        }

        public string GetCurrentItem()
        {
            return _list[_current];
        }
    }
}
