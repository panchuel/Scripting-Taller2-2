using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_2
{
    class GameMain
    {
        static void Main(string[] args)
        {
            Player p1, p2;
            p1 = new Player();
            p2 = new Player();

            int index;

            Console.WriteLine("BIENVENIDO A SACA CANAS\n" + "1. Genera una baraja aleatoria         2. Combate contra un adversario\n");
            index = int.Parse(Console.ReadLine());
            /*while(index < 1 || index > 2)
            {
                Console.WriteLine("Opción invalida, intente de nuevo");              
                index = int.Parse(Console.ReadLine());
            }*/

            if(index == 1)                                                                                          //Hace las pruebas de que solo se pueda agregar una carta si el CP de esta es menor o igual al CP restante de la baraja 
            {                                                                                                       //y tambien evalua que se reste el CP de la baraja al añadir una carta
                Console.WriteLine("CP Total " + p1.deck.cP);
                while (p1.deck.cP > 0)
                {
                    p1.deck.AddCard();

                    Console.WriteLine("Personajes Restantes " + p1.deck.charTotal + " \nCP " + p1.deck.cP);
                }

                for (int i = 0; i < p1.deck.deck.Count; i++)
                {
                    Console.WriteLine(p1.deck.deck[i].name);
                }
            }
            
            if(index == 2)
            {
                Console.WriteLine("Ahora lo implemento, teta");
            }
            if (index == 3) 
            {
                Console.WriteLine("gacha");


            }
        } 
        
    }
}
