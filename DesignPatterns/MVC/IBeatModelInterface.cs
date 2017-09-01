using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    interface IBeatModelInterface
    {
        void Initialize();
        void On();
        void Off();
        void SetBpm(int bpm);
        int GetBpm();
        void RegisterObserver(BeatObserver o);
        void RemoveObserver(BeatObserver o);
        void RegisterObserver(BpmObserver o);
        void RemoveObserver(BpmObserver o);
    }
}
