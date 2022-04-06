using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_2
{
    public class Equip : Card, IValues
    {
        public TargetAtribute tA;
        public int eP;
        string[] namesKnight = { "Sheald", "Spear", "Chesplate" }, namesMage = { "Staff", "Hat", "Ring" }, namesUndead = { "Rags", "Cape", "Sword" };
        public Equip equip;
        int caseIDTA, caseIDA,nameIndex;
        public Affinity affinity;

        public void ApplyValues()
        {
            cP = rnd.Next(1, 5);
            eP = rnd.Next(1, 3);
            caseIDTA = rnd.Next(0, 3);
            caseIDA = rnd.Next(0, 4);

            switch (caseIDTA)
            {
                case 0: //AP
                    tA = TargetAtribute.AP;
                    break;
                case 1: //RP
                    tA = TargetAtribute.RP;
                    break;
                case 2: //All
                    tA = TargetAtribute.ALL;
                    break;
            }

            switch (caseIDA)
            {
                case 0: //Knight
                    nameIndex = rnd.Next(0, namesKnight.Length);
                    name = namesKnight[nameIndex] + " Es un equipamiento";
                    affinity = Affinity.Knight;
                    break;
                case 1: //Mage
                    nameIndex = rnd.Next(0, namesMage.Length);
                    name = namesMage[nameIndex] + " Es un equipamiento";
                    affinity = Affinity.Mage;
                    break;                   
                case 2: //Undead
                    nameIndex = rnd.Next(0, namesUndead.Length);
                    name = namesUndead[nameIndex] + " Es un equipamiento";
                    affinity = Affinity.Undead;
                    break;
                case 3: //All
                    nameIndex = rnd.Next(0, namesUndead.Length);
                    name = namesUndead[nameIndex] + " Es un equipamiento";
                    affinity = Affinity.All;
                    break;
            }
        }
    }
}
