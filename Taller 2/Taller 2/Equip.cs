using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_2
{
    public class Equip : Card, IValues
    {
        TargetAtribute tA;
        int eP;
        public Affinity affinity;

        void ApplyValues()
        {
            cP = rnd.Next(2, 7);
        }
    }
}
