using System;

namespace AdapterFacade.DuckAdapter
{
    public class DuckAdapter : ITurkey
    {
        private readonly IDuck _duckAdapter;

        public DuckAdapter(IDuck duckAdapter)
        {
            _duckAdapter = duckAdapter;
        }

        public void Fly()
        {
            Console.WriteLine("Fly less");
        }

        public void Gobble()
        {
            _duckAdapter.Quack();
        }
    }
}
