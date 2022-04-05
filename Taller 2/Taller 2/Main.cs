using System;

namespace Taller_2
{
    class GameMain
    {
        static void Main(string[] args)
        {
            Combat combat = new Combat();
            int option;
            Console.WriteLine("Seleciona 1 para agregar cartas a tu maso!\nSelecciona 2 para luchar");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                combat.player1 = new Player();
                for (int i = 0; i < combat.player1.deck.deckChar.Count; i++)
                {
                    Console.WriteLine(combat.player1.deck.deckChar[i].aP);
                }
                
                
            }
        }
    }
}
