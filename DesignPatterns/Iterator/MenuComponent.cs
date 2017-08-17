using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent component)
        {

        }

        public virtual void Remove(MenuComponent component)
        {

        }

        public virtual MenuComponent GetChild(int i)
        {
            throw new NotImplementedException();
        }

        public virtual string GetName()
        {
            throw new NotImplementedException();
        }

        public virtual string GetDescription()
        {
            throw new NotImplementedException();
        }

        public virtual double GetPrice()
        {
            throw new NotImplementedException();
        }

        public virtual bool IsVegeterian()
        {
            throw new NotImplementedException();
        }

        public virtual void Print()
        {
            
        }
    }
}
