using System;
using System.Runtime.InteropServices;

namespace Iterator
{
    class MenuItem : MenuComponent
    {
        private readonly string _name;
        private readonly string _description;
        private readonly bool _isVegeterian;
        private readonly double _price;

        public MenuItem(string name, string description, double price, bool isVegeterian)
        {
            _price = price;
            _name = name;
            _description = description;
            _isVegeterian = isVegeterian;
        }

        public override string GetName()
        {
            return _name;
        }

        public override double GetPrice()
        {
            return _price;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override bool IsVegeterian()
        {
            return _isVegeterian;
        }

        public override void Print()
        {
            Console.WriteLine(GetName());
            if(IsVegeterian())
                Console.WriteLine("V");
            Console.WriteLine(GetPrice());
            Console.WriteLine(GetDescription());
        }
    }
}
