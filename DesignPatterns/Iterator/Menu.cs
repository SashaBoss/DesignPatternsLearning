using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Menu : MenuComponent
    {
        private string _name;
        private string _description;
        private List<MenuComponent> _menuComponents;

        public Menu(string name, string description)
        {
            _menuComponents = new List<MenuComponent>();
            _name = name;
            _description = description;
        }

        public override void Add(MenuComponent component)
        {
            _menuComponents.Add(component);
        }

        public override void Remove(MenuComponent component)
        {
            _menuComponents.Remove(component);
        }

        public override MenuComponent GetChild(int i)
        {
            return _menuComponents.ElementAt(i);
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override void Print()
        {
            Console.WriteLine(GetName());
            Console.WriteLine(GetDescription());

            var iterator = _menuComponents.GetEnumerator();
            while (iterator.MoveNext())
            {
                MenuComponent mc = iterator.Current;
                mc?.Print();
            }
        }
    }
}
