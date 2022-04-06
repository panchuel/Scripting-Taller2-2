using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_2
{
    class SupportSkill : Card, IValues
    {
        string[] names = {"ReduceAP", "ReduceRP", "ReduceAll", "DestroyEquip", "RestoreAP"};
        int eP, caseID;
        public EffectType eType;

        public void ApplyValues()
        {
            cP = rnd.Next(1, 5);
            eP = rnd.Next(1, 4);
            caseID = rnd.Next(0, 5);
            switch (caseID)
            {
                case 0: //ReduceAp
                    name = names[0] + " Es un skill";
                    eType = EffectType.ReduceAP;
                    break;

                case 1: //ReduceRP
                    name = names[1] + " Es un skill";
                    eType = EffectType.ReduceRP;
                    break;

                case 2: //ReduceAll
                    name = names[2] + " Es un skill";
                    eType = EffectType.ReduceAll;
                    break;

                case 3: //DestroyEquip
                    eP = 0;
                    name = names[3] + " Es un skill";
                    eType = EffectType.DestroyEquip;
                    break;

                case 4: //RestoreRP
                    name = names[4] + " Es un skill";
                    eType = EffectType.RestoreRP;
                    break;
            }
        }

    }
}
