using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_2
{
    class SupportSkill : Card, IValues
    {
        int eP, caseID;
        public EffectType eType;

        void ApplyValues()
        {
            eP = rnd.Next(1, 4);
            caseID = rnd.Next(0, 5);
            switch (caseID)
            {
                case 0: //ReduceAp
                    eType = EffectType.ReduceAP;
                    break;

                case 1: //ReduceRP
                    eType = EffectType.ReduceRP;
                    break;

                case 2: //ReduceAll
                    eType = EffectType.ReduceAll;
                    break;

                case 3: //DestroyEquip
                    eType = EffectType.DestroyEquip;
                    break;

                case 4: //RestoreRP
                    eType = EffectType.RestoreRP;
                    break;
            }
        }

    }
}
