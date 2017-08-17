using System;
using System.Collections.Generic;
using System.Linq;

namespace Iterator
{
    class PancakeMenuIterator : IIterator
    {
        private List<MenuItem> _items;
        private int _index;

        public PancakeMenuIterator(List<MenuItem> items)
        {
            _items = items;
            _index = 0;
        }

        public bool HasNext()
        {
            return _items.GetEnumerator().MoveNext();
        }

        public object Next()
        {
            return _items.GetEnumerator().Current;
        }
    }
}
