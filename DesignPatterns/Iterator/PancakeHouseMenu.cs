using System.Collections.Generic;

namespace Iterator
{
    public class PancakeHouseMenu : IMenu
    {
        private readonly List<MenuItem> _menuItems;

        public PancakeHouseMenu()
        {
            _menuItems = new List<MenuItem>();
            AddItem("Pancakes with eggs", "Good", 24.5, true);
            AddItem("Beef", "Good", 224.5, false);
            AddItem("Caesar", "Fresh", 14.5, true);
        }

        public void AddItem(string name, string description, double price, bool isVegeterian)
        {
            _menuItems.Add(new MenuItem(name, description, price, isVegeterian));
        }

        public IIterator CreateIterator()
        {
            return new PancakeMenuIterator(_menuItems);
        }
    }
}
