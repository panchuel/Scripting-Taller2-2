using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_2
{
    class Character : Card, IValues
    {
        public int aP, rP;
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
                    name = namesKnight[nameIndex] + " Es un personaje ";
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

                    name = namesMage[nameIndex] + " Es un personaje ";
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
                    
                    name = namesUndead[nameIndex] + " Es un personaje ";
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

        public void ModifyAP(Character p1, Character p2)        //Piedra papel o tijera
        {
            if(p1.affinity == Affinity.Knight && p2.affinity == Affinity.Mage || p1.affinity == Affinity.Mage && p2.affinity == Affinity.Undead || p1.affinity == Affinity.Undead && p2.affinity == Affinity.Knight)
            {
                p1.aP += 1;
                p2.aP -= 1;
            }
            if (p2.affinity == Affinity.Knight && p1.affinity == Affinity.Mage || p2.affinity == Affinity.Mage && p1.affinity == Affinity.Undead || p2.affinity == Affinity.Undead && p1.affinity == Affinity.Knight)
            {
                p1.aP -= 1;
                p2.aP += 1;
            }
        }
    }
}
