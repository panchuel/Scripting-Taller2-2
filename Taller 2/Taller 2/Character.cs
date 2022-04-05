using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_2
{
    class Character : Card, IValues
    {
        public int aP, rP;
        int caseID;
        public Equip equip;
        public Equip[] arrEquip = new Equip[3];
        Affinity affinity;

        void ApplyValues()
        {
            cP = rnd.Next(2, 7);
            aP = rnd.Next(1, 5);
            rP = rnd.Next(1, 5);

            switch (caseID)
            {
                case 1: //Knight
                    affinity = Affinity.Knight;
                    break;
                case 2: //Mage
                    affinity = Affinity.Mage;
                    break;
                case 3: //Undead
                    affinity = Affinity.Undead;
                    break;
            }
        }

        public void Equip()
        {
            if(equip.affinity == Affinity.Knight)
            {
                for (int i = 0; i < arrEquip.Length; i++)
                {
                    if (arrEquip[i] == null) arrEquip[i] = equip;
                }
            }
        }
    }
}
