using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_2
{
    class Deck
    {
        public int cP, charTotal, equipTotal, suppTotal, caseID;
        int maxCP, charMax = 5, equipMax = 10, suppMax = 5;
        Random rnd = new Random();
        public List<Card> deck;
        public Character character;
        public Equip equip;
        public SupportSkill support;

        public Deck(int cpMax)
        {
            maxCP = cpMax;
            cP = maxCP;
            charTotal = charMax;
            equipTotal = equipMax;
            suppTotal = suppMax;
        }

        public Deck()
        {
            maxCP = rnd.Next(25, 40);
            cP = maxCP;
            charTotal = charMax;
            equipTotal = equipMax;
            suppTotal = suppMax;
        }

        public void AddCard()
        {
            while(cP >= 0)
            {
                caseID = rnd.Next(0, 3);

                switch (caseID)
                {
                    case 0: //Character
                        if(charTotal >= 0)
                        {
                            character = new Character();
                            if (character.cP <= cP)
                            {
                                charTotal -= 1;
                                cP -= character.cP;
                                deck.Add(character);
                            }
                        }                                                
                        break;
                    case 1: //Equip
                        if (equipTotal >= 0)
                        {
                            equip = new Equip();
                            if (equip.cP <= cP)
                            {
                                equipTotal -= 1;
                                cP -= equip.cP;
                                deck.Add(equip);
                            }
                        }
                        break;
                    case 2: //SupportSkill
                        if (suppTotal >= 0)
                        {
                            support = new SupportSkill();
                            if (support.cP <= cP)
                            {
                                suppTotal -= 1;
                                cP -= support.cP;
                                deck.Add(support);
                            }
                        }
                        break;
                }
            }
            
        }
    }
}
