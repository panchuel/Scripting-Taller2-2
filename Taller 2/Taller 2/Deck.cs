using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_2
{
    class Deck
    {
        int cP, charTotal, equipTotal, suppTotal, caseID;
        int maxCP, charMax = 5, equipMax = 10, suppMax = 5;
        Random rnd = new Random();
        List<Card> deck;
        Card card;

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
                            card = new Character();
                            if (card.cP <= cP)
                            {
                                charTotal -= 1;
                                cP -= card.cP;
                                deck.Add(card);
                            }
                        }                                                
                        break;
                    case 1: //Equip
                        if (equipTotal >= 0)
                        {
                            card = new Equip();
                            if (card.cP <= cP)
                            {
                                equipTotal -= 1;
                                cP -= card.cP;
                                deck.Add(card);
                            }
                        }
                        break;
                    case 2: //SupportSkill
                        if (suppTotal >= 0)
                        {
                            card = new Character();
                            if (card.cP <= cP)
                            {
                                suppTotal -= 1;
                                cP -= card.cP;
                                deck.Add(card);
                            }
                        }
                        break;
                }
            }
            
        }
    }
}
