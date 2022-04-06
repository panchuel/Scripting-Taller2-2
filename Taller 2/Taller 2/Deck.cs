using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_2
{
    class Deck
    {
        public int cP, charTotal, equipTotal, suppTotal, caseID, charCount = 0;
        int maxCP, charMax = 5, equipMax = 10, suppMax = 5;
        Random rnd = new Random();
        public List<Card> deck = new List<Card>();
        public Character character;
        public Equip equip;
        public SupportSkill support;

        public Deck()
        {
            maxCP = rnd.Next(20, 40);
            cP = maxCP;
            charTotal = charMax;
            equipTotal = equipMax;
            suppTotal = suppMax;
        }

        public void AddCard()
        {
            caseID = rnd.Next(0, 3);

            switch (caseID)
            {
                case 0: //Character
                    if (charTotal <= 0)
                    {
                        break;
                    }
                    else
                    {
                        character = new Character();
                        character.ApplyValues();
                        if (character.cP <= cP)
                        {
                            charTotal -= 1;
                            charCount++;
                            cP -= character.cP;
                            Console.WriteLine("Coste de carta " + character.cP);
                            deck.Add(character);
                        }
                    }
                    break;
                case 1: //Equip
                    if(equipTotal <= 0)
                    {
                        break;
                    }
                    else
                    {
                        equip = new Equip();
                        equip.ApplyValues();
                        if (equip.cP <= cP)
                        {
                            equipTotal -= 1;
                            cP -= equip.cP;
                            Console.WriteLine("Coste de carta " + equip.cP);
                            deck.Add(equip);
                        }
                    }                   
                    break;
                case 2: //SupportSkill
                    if (suppTotal <= 0)
                    {
                        break;
                    }
                    else
                    {
                        support = new SupportSkill();
                        support.ApplyValues();
                        if (support.cP <= cP)
                        {
                            suppTotal -= 1;
                            cP -= support.cP;
                            Console.WriteLine("Coste de carta " + support.cP);
                            deck.Add(support);
                        }
                    }
                    break;
            }
        }
    }
}
