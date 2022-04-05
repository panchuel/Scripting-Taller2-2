using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_2
{
    public class Equip : Card, IValues
    {
        public TargetAtribute tA;
        int eP, caseIDTA, caseIDA;
        public Affinity affinity;

        void ApplyValues()
        {
            cP = rnd.Next(2, 7);
            eP = rnd.Next(1, 3);
            caseIDTA = rnd.Next(0, 3);

            switch (caseIDTA)
            {
                case 1: //AP
                    tA = TargetAtribute.AP;
                    break;
                case 2: //RP
                    tA = TargetAtribute.RP;
                    break;
                case 3: //All
                    tA = TargetAtribute.ALL;
                    break;
            }
        }
    }
}
