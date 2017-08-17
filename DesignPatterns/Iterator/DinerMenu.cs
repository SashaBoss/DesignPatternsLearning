using System;

namespace Iterator
{
    public class DinerMenu : IMenu
    {
        public static int MaxItems = 6;
        private int _numbeOffItems = 0;
        private readonly MenuItem[] _menuItems;

        public DinerMenu()
        {
            _menuItems = new MenuItem[MaxItems];
        }

        public void AddItem(string name, string description, double price, bool isVegeterian)
        {
            if (_numbeOffItems >= MaxItems)
            {
                Console.Error.WriteLine("Menu is full");
            }
            else
            {
                _menuItems[_numbeOffItems++] = new MenuItem(name, description, price, isVegeterian);
            }
        }

        public IIterator CreateIterator()
        {
            return new DinerMenuIterator(_menuItems);
        }
    }
}
