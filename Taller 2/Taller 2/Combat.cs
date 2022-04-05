using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_2
{
    class Combat
    {
        public Player player1, player2;
        Equip equip;
        int charCount1, charCount2;
        public Combat()
        {
            player1 = new Player();
            player2 = new Player();
        }

        public void Figth()
        {
            //Lose();
            for (int i = 0; i < player1.deck.deckChar.Count; i++)
            {
                while (player1.deck.character.rP >= 0)
                {
                    for (int j = 0; j < player2.deck.deckChar.Count; j++)
                    {
                        if (player1.deck.character.aP <= player2.deck.character.aP || player1.deck.character.aP == player2.deck.character.aP || player1.deck.character.aP >= player2.deck.character.aP)
                        {
                            player1.deck.character.rP -= player2.deck.character.aP;
                            Console.WriteLine(player1.deck.character.rP);
                            player2.deck.character.rP -= player1.deck.character.aP;
                            Console.WriteLine(player2.deck.character.rP);
                            if (player1.deck.character.rP <= 0)
                            {
                                charCount1--;
                                player1.deck.deckChar[i] = null;
                            }

                            if (player2.deck.character.rP <= 0)
                            {
                                charCount2--;
                                player1.deck.deckChar[j] = null;
                            }
                            break;
                        }
                    }
                }
            }
        }

        public void DestroyEquip()
        {
            for (int i = 0; i < player1.deck.deckSkill.Count; i++)
            {
                if (player1.deck.deckSkill[i].eType == EffectType.DestroyEquip)
                {
                    for (int j = 0; j < player2.deck.deckChar.Count; j++)                                                               //Revisa el deck del player 2
                    {
                        for (int k = 0; k < player2.deck.character.arrEquip.Length; k++)                                                //Revisa los espacios de equipo del character del player 2
                        {
                            if (player2.deck.character.arrEquip[k] != null)                                                             //Destruye el equipamiento del character y resta los respectivos effect points
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
                                for (int l = 0; l < player2.deck.deckEquip.Count; l++)
                                {
                                    if (player2.deck.deckEquip[l] == equip) player2.deck.deckEquip[l] = null;
                                }
                            }
                            break;
                        }
                    }
                    break;
                }
            }           
        }

        /*public void Lose()
        {
            for (int i = 0; i < player1.deck.deck.Count; i++)
            {
                if (player1.deck.deck[i] == player1.deck.character) charCount1++;
            }

            for (int i = 0; i < player2.deck.deck.Count; i++)
            {
                if (player2.deck.deck[i] == player2.deck.character) charCount2++;
            }

            if (charCount1 == 0) Console.WriteLine("Perdio el jugador 1");
            if (charCount2 == 0) Console.WriteLine("Perdio el jugador 2");
        }*/
    }
}
