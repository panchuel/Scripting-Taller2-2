using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_2
{
    class SupportSkill : Card, IValues
    {
        string[] names = {"ReduceAP", "ReduceRP", "ReduceAll", "DestroyEquip", "RestoreAP" };
        int eP, caseID, raretyp;
        public EffectType eType;
        public Rarety raeza;

        public void ApplyValues()
        {
            cP = rnd.Next(1, 5);
            eP = rnd.Next(1, 4);
            caseID = rnd.Next(0, 5);
            raretyp = rnd.Next(0, 3);
            switch (caseID)
            {
                case 0: //ReduceAp
                    
                    name = names[0] + " Es un skill" ;
                    eType = EffectType.ReduceAP;
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

                case 1: //ReduceRP
                    
                    name = names[1] + " Es un skill";
                    eType = EffectType.ReduceRP;
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

                case 2: //ReduceAll
                    
                    name = names[2] + " Es un skill";
                    eType = EffectType.ReduceAll;
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

                case 3: //DestroyEquip
                    eP = 0;

                    name = names[3] + " Es un skill";
                    eType = EffectType.DestroyEquip;
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

                case 4: //RestoreRP

                    name = names[4] + " Es un skill";
                    eType = EffectType.RestoreRP;
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

    }
}
