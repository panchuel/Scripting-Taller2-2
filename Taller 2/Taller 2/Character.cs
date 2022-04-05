using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_2
{
    class Character : Card, IValues
    {
        public int aP, rP;
        int caseID;
        string name;
        public Equip equip;
        public Equip[] arrEquip = new Equip[3];
        Affinity affinity;

        public Character()
        {
            aP = rnd.Next(1, 5);
            rP = rnd.Next(1, 5);
            cP = rnd.Next(2, 7);
            name = "";          
        }

        public void ApplyValues()
        {
            caseID = rnd.Next(0,3);
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
            //Asign Effect Point
            if (equip.tA == TargetAtribute.AP) aP += equip.eP;
            else if (equip.tA == TargetAtribute.RP) rP += equip.eP;
            else
            {
                aP += equip.eP;
                rP += equip.eP;
            }

            //Equip
            if (caseID == 0)
            {

                if (equip.affinity == Affinity.Knight)
                {
                    for (int i = 0; i < arrEquip.Length; i++)
                    {
                        if (arrEquip[i] == null) arrEquip[i] = equip;
                    }
                }
            }
            
            else if(caseID == 1)
            {
                if (equip.affinity == Affinity.Mage)
                {
                    for (int i = 0; i < arrEquip.Length; i++)
                    {
                        if (arrEquip[i] == null) arrEquip[i] = equip;
                    }
                }
            }

            else
            {
                if (equip.affinity == Affinity.Undead)
                {
                    for (int i = 0; i < arrEquip.Length; i++)
                    {
                        if (arrEquip[i] == null) arrEquip[i] = equip;
                    }
                }
            }
        }
    }
}
