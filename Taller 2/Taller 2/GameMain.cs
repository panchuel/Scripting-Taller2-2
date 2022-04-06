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

            int index, index2, ap1, ap2, rp1, rp2, respuesta;

            Console.WriteLine("BIENVENIDO A SACA CANAS\n" + "1. Genera una baraja aleatoria         2. Combate contra un adversario\n");
            index = int.Parse(Console.ReadLine());
            while(index < 1 || index > 2)
            {
                Console.WriteLine("Opción invalida, intente de nuevo");              
                index = int.Parse(Console.ReadLine());
            }

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
                    Console.WriteLine(i+1 + " " + p1.deck.deck[i].name);

                }
            }
            
            if(index == 2)
            {
                Console.WriteLine("\nHORA DE COMBATIR! \n" + "1. Ver tu Deck              2. LUCHAR!");

                index = int.Parse(Console.ReadLine());
                while (index < 1 || index > 2)
                {
                    Console.WriteLine("\nOpción invalida, intente de nuevo");
                    index = int.Parse(Console.ReadLine());
                }

                if(index == 1 && p1.deck.deck.Count == 0)                                                               //Revisa que no haya un deck creado para el P1
                {
                    while (p1.deck.cP > 0)
                    {
                        p1.deck.AddCard();

                        Console.WriteLine("Personajes Restantes " + p1.deck.charTotal + " \nCP " + p1.deck.cP);
                    }

                    for (int i = 0; i < p1.deck.deck.Count; i++)
                    {
                        Console.WriteLine(i + 1 + " " + p1.deck.deck[i].name);
                    }

                    Console.WriteLine("2. LUCHAR!");
                    index = int.Parse(Console.ReadLine());
                    while (index != 2)
                    {
                        Console.WriteLine("\nOpción invalida, intente de nuevo");
                        index = int.Parse(Console.ReadLine());
                    }
                }

                else if(index == 1 && p1.deck.deck.Count != 0)                                                          //Si hay un Deck generado (porque se marcó antes ver deck)
                {
                    for (int i = 0; i < p1.deck.deck.Count; i++)
                    {
                        Console.WriteLine(i + 1 + " " + p1.deck.deck[i].name);
                    }

                    Console.WriteLine("2. LUCHAR!");
                    index = int.Parse(Console.ReadLine());
                    while (index != 2)
                    {
                        Console.WriteLine("\nOpción invalida, intente de nuevo");
                        index = int.Parse(Console.ReadLine());
                    }
                }

                if(index == 2)                                                                                          //Menú De Combate
                {
                    Console.WriteLine("\n¿Que harás?\n1.Combatir    2.Destruir Equipo           3. Equipar Objetos");
                    index = int.Parse(Console.ReadLine());
                    if(p1.deck.deck.Count == 0)
                    {
                        while (p1.deck.cP > 0)
                        {
                            p1.deck.AddCard();

                            Console.WriteLine("Personajes Restantes " + p1.deck.charTotal + " \nCP " + p1.deck.cP);
                        }

                        for (int i = 0; i < p1.deck.deck.Count; i++)
                        {
                            Console.WriteLine(i + 1 + " " + p1.deck.deck[i].name);
                        }
                    }
                    while (index < 1 || index > 3)
                    {
                        Console.WriteLine("\nOpción invalida, intente de nuevo");
                        index = int.Parse(Console.ReadLine());
                    }

                    if(index == 1)                                                                                      //Combate
                    {
                        for (int i = 0; i < p1.deck.deck.Count; i++)
                        {
                            Console.WriteLine(i + 1 + " " + p1.deck.deck[i].name);
                        }
                        Console.WriteLine("Selecciona con que character atacarás");                                     //Selección del character que atacará
                        index = int.Parse(Console.ReadLine());

                        while (p1.deck.deck[index] is Equip || p1.deck.deck[index] is SupportSkill)
                        {
                            Console.WriteLine("\nOpción invalida, intente de nuevo");
                            index = int.Parse(Console.ReadLine());
                        }

                        if(p1.deck.deck[index] is Character)
                        {
                            index2 = index;
                            while (p2.deck.cP > 0)
                            {
                                p2.deck.AddCard();                              
                            }
                            for (int i = 0; i < p2.deck.deck.Count; i++)
                            {
                                Console.WriteLine(i + 1 + " " + p2.deck.deck[i].name);
                            }
                            Console.WriteLine("¿Que Character atacarás?");                                              //Selección character a atacar
                            index = int.Parse(Console.ReadLine());

                            while (p2.deck.deck[index] is Equip || p2.deck.deck[index] is SupportSkill)
                            {
                                Console.WriteLine("\nOpción invalida, intente de nuevo");
                                index = int.Parse(Console.ReadLine());
                            }
                            if(p2.deck.deck[index] is Character && p1.deck.deck[index2] is Character)
                            {
                                if ((p1.deck.deck[index2] as Character).affinity == Affinity.Knight && (p2.deck.deck[index] as Character).affinity == Affinity.Mage || (p1.deck.deck[index2] as Character).affinity == Affinity.Mage && (p2.deck.deck[index] as Character).affinity == Affinity.Undead || (p1.deck.deck[index2] as Character).affinity == Affinity.Undead && (p2.deck.deck[index] as Character).affinity == Affinity.Knight)
                                {
                                    (p1.deck.deck[index2] as Character).aP += 1;
                                    (p2.deck.deck[index] as Character).aP -= 1;
                                }
                                if ((p2.deck.deck[index] as Character).affinity == Affinity.Knight && (p1.deck.deck[index2] as Character).affinity == Affinity.Mage || (p2.deck.deck[index] as Character).affinity == Affinity.Mage && (p1.deck.deck[index2] as Character).affinity == Affinity.Undead || (p2.deck.deck[index] as Character).affinity == Affinity.Undead && (p1.deck.deck[index2] as Character).affinity == Affinity.Knight)
                                {
                                    (p1.deck.deck[index2] as Character).aP -= 1;
                                    (p2.deck.deck[index] as Character).aP += 1;
                                }

                                rp1 = (p1.deck.deck[index2] as Character).rP;
                                rp2 = (p2.deck.deck[index] as Character).rP;
                                ap1 = (p1.deck.deck[index2] as Character).aP;
                                ap2 = (p2.deck.deck[index] as Character).aP;
                                Console.WriteLine("P1 AP RP" + "            " + "P2 AP RP\n" + "  " + ap1 + " " + rp1 + "       " + "  " + ap2 + " " + rp2);

                                rp1 -= ap2;
                                rp2 -= ap1;
                                Console.WriteLine("Despues de combate los puntos son");
                                Console.WriteLine("P1 AP RP" + "            " + "P2 AP RP\n" + "  " + ap1 + " " + rp1 + "       " + "  " + ap2 + " " + rp2);

                                if (rp2 <= 0)
                                {
                                    p2.deck.deck[index] = null;
                                    if(p2.deck.deck[index] == null) Console.WriteLine("Se destruyó la carta de P2");

                                }
                                else if (rp1 <= 0)
                                {
                                    p1.deck.deck[index2] = null;
                                    if (p1.deck.deck[index2] == null) Console.WriteLine("Se destruyó la carta P1");
                                }

                                while (rp2 > 0 && rp1 > 0)
                                {
                                    Console.WriteLine("Pelear de nuevo?\n 1. Si             2. No");
                                    respuesta = int.Parse(Console.ReadLine());

                                    if(respuesta == 1)
                                    {
                                        rp1 -= ap2;
                                        rp2 -= ap1;
                                        Console.WriteLine("Despues de combate los puntos son");
                                        Console.WriteLine("P1 AP RP" + "            " + "P2 AP RP\n" + "  " + ap1 + " " + rp1 + "       " + "  " + ap2 + " " + rp2);

                                        if (rp2 <= 0)
                                        {
                                            p2.deck.deck[index] = null;
                                            if (p2.deck.deck[index] == null) Console.WriteLine("Se destruyó la carta de P2");

                                        }
                                        else if (rp1 <= 0)
                                        {
                                            p1.deck.deck[index2] = null;
                                            if (p1.deck.deck[index2] == null) Console.WriteLine("Se destruyó la carta P1");
                                        }
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }

                    if(index == 2)
                    {
                        for (int i = 0; i < p1.deck.deck.Count; i++)
                        {
                            Console.WriteLine(i + 1 + " " + p1.deck.deck[i].name);
                        }
                        Console.WriteLine("Selecciona con que Skill atacarás (DestroyEquip)");                          //Se selecciona el DestroyEquip
                        index = int.Parse(Console.ReadLine());

                        while (p1.deck.deck[index] is Equip || p1.deck.deck[index] is Character || (p1.deck.deck[index] as SupportSkill).eType != EffectType.DestroyEquip)
                        {
                            Console.WriteLine("\nOpción invalida, intente de nuevo");
                            index = int.Parse(Console.ReadLine());
                        }
                        if(p1.deck.deck[index] is SupportSkill)
                        {
                            index2 = index;
                            while (p2.deck.cP > 0)
                            {
                                p2.deck.AddCard();
                            }
                            for (int i = 0; i < p2.deck.deck.Count; i++)
                            {
                                Console.WriteLine(i + 1 + " " + p2.deck.deck[i].name);
                            }
                            Console.WriteLine("¿Que equipo destruiras?");                                              //Selección Equip a destruir
                            index = int.Parse(Console.ReadLine());

                            while (p2.deck.deck[index] is Character || p2.deck.deck[index] is SupportSkill)
                            {
                                Console.WriteLine("\nOpción invalida, intente de nuevo");
                                index = int.Parse(Console.ReadLine());
                            }
                            if (p2.deck.deck[index] is Equip && p1.deck.deck[index2] is SupportSkill && (p1.deck.deck[index2] as SupportSkill).eType == EffectType.DestroyEquip)
                            {
                                Console.WriteLine("Se destruyó el equipo " + p2.deck.deck[index].name);
                                p2.deck.deck[index] = null;
                            }
                        }
                    }

                    if(index == 3)
                    {
                        Console.WriteLine("\nSelecciona que objeto equiparás");                                       //Se selecciona el Objeto a equipar
                        index = int.Parse(Console.ReadLine());
                        
                        while (p1.deck.deck[index] is SupportSkill || p1.deck.deck[index] is Character)
                        {
                            Console.WriteLine("\nOpción invalida, intente de nuevo");
                            index = int.Parse(Console.ReadLine());
                        }

                        Console.WriteLine("\nSelecciona el personaje al que se lo pondras");                            //Se selecciona el personaje a equipar
                        index2 = int.Parse(Console.ReadLine());

                        while (p1.deck.deck[index2] is SupportSkill || p1.deck.deck[index2] is Equip)
                        {
                            Console.WriteLine("\nOpción invalida, intente de nuevo");
                            index2 = int.Parse(Console.ReadLine());
                        }

                        if ((p1.deck.deck[index] as Equip).affinity == (p1.deck.deck[index2] as Character).affinity || (p1.deck.deck[index] as Equip).affinity == Affinity.All)
                        {
                            (p1.deck.deck[index2] as Character).equip = new Equip();
                            (p1.deck.deck[index2] as Character).equip = (p1.deck.deck[index] as Equip);
                            (p1.deck.deck[index2] as Character).arrEquip[(p1.deck.deck[index2] as Character).equipSlot] = (p1.deck.deck[index2] as Character).equip;                            
                            if((p1.deck.deck[index2] as Character).equipSlot >= 0 && (p1.deck.deck[index2] as Character).equipSlot < 4)
                            {
                                (p1.deck.deck[index2] as Character).Equip((p1.deck.deck[index2] as Character).equipSlot);
                                for (int i = 0; i < (p1.deck.deck[index2] as Character).arrEquip.Length; i++)
                                {
                                    if(p1.deck.character.arrEquip[i] != null) Console.WriteLine(p1.deck.character.arrEquip[i].name);
                                }
                                (p1.deck.deck[index2] as Character).equipSlot++;
                            }   
                        }
                    }
                }
            }
        } 
        
    }
}