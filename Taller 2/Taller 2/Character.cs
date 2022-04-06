using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_2
{
    class Character : Card, IValues
    {
        public int aP, rP, equipSlot = 0;
        int caseID, nameIndex, raretyp;
        string[] namesKnight = { "Knight", "Dark Knight", "Viking" }, namesMage = { "Mage", "ForestMage", "Wizzard" }, namesUndead = { "Zombie", "Vampire", "Skeleton" };
        public Equip equip;
        public Equip[] arrEquip = new Equip[3];
        public Affinity affinity;
        public Rarety raeza;

        public Character()
        {
            aP = rnd.Next(1, 5);
            rP = rnd.Next(1, 5);
            cP = rnd.Next(1, 5);
            caseID = rnd.Next(0, 3);
            raretyp = rnd.Next(0, 3);
        }

        public void ApplyValues()
        {           
            switch (caseID)
            {
                case 0: //Knight
                    nameIndex = rnd.Next(0, namesKnight.Length);
                    name = namesKnight[nameIndex] + " Es un personaje caballero";
                    affinity = Affinity.Knight;
                    switch (raretyp) 
                    {
                        case 0: 
                            raeza = Rarety.Common;
                            break;
                        case 1:
                            raeza = Rarety.Rare;
                            break;
                        case 2:
                            raeza = Rarety.SuperRare;
                            break;
                        case 3:
                            raeza = Rarety.UltraRare;
                            break;
                    }
                    

                    break;
                case 1: //Mage
                    nameIndex = rnd.Next(0, namesMage.Length);
                    name = namesMage[nameIndex] + " Es un personaje mago";
                    affinity = Affinity.Mage;
                    switch (raretyp)
                    {
                        case 0:
                            raeza = Rarety.Common;
                            break;
                        case 1:
                            raeza = Rarety.Rare;
                            break;
                        case 2:
                            raeza = Rarety.SuperRare;
                            break;
                        case 3:
                            raeza = Rarety.UltraRare;
                            break;
                    }

                    break;
                case 2: //Undead
                    nameIndex = rnd.Next(0, namesUndead.Length);
                    name = namesUndead[nameIndex] + " Es un personaje no muerto";
                    affinity = Affinity.Undead;
                    switch (raretyp)
                    {
                        case 0:
                            raeza = Rarety.Common;
                            break;
                        case 1:
                            raeza = Rarety.Rare;
                            break;
                        case 2:
                            raeza = Rarety.SuperRare;
                            break;
                        case 3:
                            raeza = Rarety.UltraRare;
                            break;
                    }
                    break;
            }
            

        }

        public void Equip(int idx)
        {
            //Asign Effect Point
            if (equip.tA == TargetAtribute.AP) aP += equip.eP;
            else if (equip.tA == TargetAtribute.RP) rP += equip.eP;
            else
            {
                aP += equip.eP;
                rP += equip.eP;
            }

            if (arrEquip[idx] == null) arrEquip[idx] = equip;           
        }
    }
}
