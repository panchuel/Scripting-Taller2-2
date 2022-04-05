using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_2
{
    class Combat
    {
        Player player1, player2;
        Equip equip;

        public Combat()
        {
            player1 = new Player();
            player2 = new Player();
        }

        void Figth()
        {

        }

        void DestroyEquip()
        {
            for (int i = 0; i < player1.deck.deck.Count; i++)
            {
                if (player1.deck.deck[i] == player1.deck.support)
                {
                    if (player1.deck.support.eType == EffectType.DestroyEquip)
                    {
                        for (int j = 0; j < player2.deck.deck.Count; j++)                                                               //Revisa el deck del player 2
                        {
                            if(player2.deck.deck[j] == player2.deck.character)
                            {
                                for (int k = 0; k < player2.deck.character.arrEquip.Length; k++)                                        //Revisa los espacios de equipo del character del player 2
                                {                                    
                                    if (player2.deck.character.arrEquip[k] != null)                                                      //Destruye el equipamiento del character y resta los respectivos effect points
                                    {
                                        equip = player2.deck.character.arrEquip[k];
                                        player2.deck.character.arrEquip[k] = null;
                                        if (equip.tA == TargetAtribute.AP) player2.deck.character.aP -= equip.eP;
                                        else if (equip.tA == TargetAtribute.RP) player2.deck.character.rP -= equip.eP;
                                        else if (equip.tA == TargetAtribute.AP)
                                        {
                                            player2.deck.character.aP -= equip.eP;
                                            player2.deck.character.rP -= equip.eP;
                                        }
                                    }                                                                                              
                                    
                                    break;
                                }
                                if (player2.deck.deck[j] == equip) player2.deck.deck[j] = null;
                                break;
                            }                           
                        }
                        break;
                    }                   
                }
            }           
        }
    }
}
