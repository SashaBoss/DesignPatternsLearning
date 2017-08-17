namespace Iterator
{
    class DinerMenuIterator : IIterator
    {
        private readonly MenuItem[] _items;
        private int _position = 0;

        public DinerMenuIterator(MenuItem[] menuItems)
        {
            _items = menuItems;
        }

        public bool HasNext()
        {
            return _position < _items.Length && _items[_position] != null;
        }

        public object Next()
        {
            return _items[_position++];
        }
    }
}
