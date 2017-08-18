using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternOfPatterns
{
    class GooseFactory : AbstractGooseFactory
    {
        public override IQuackable CreateHonk()
        {
            return new GooseAdapter(new Goose());
        }
    }
}
