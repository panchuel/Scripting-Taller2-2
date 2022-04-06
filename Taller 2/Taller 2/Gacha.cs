using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_2
{
    public class Gacha:Card
    {

           
        public Gacha() 
        {
            //generar cartas
            Character personaje;
            Equip equipo;
            SupportSkill sup;

            int proba;
            proba = rnd.Next(0, 10);


            void gachapon()

            {
                //probabilidades
                switch (proba)
                {
                    case 0:
                        personaje = new Character();
                        personaje.ApplyValues();
                        genrate_cartas();

                        //character
                        break;
                    case 1://
                        equipo = new Equip();
                        equipo.ApplyValues();
                        genrate_cartas();

                        //equip
                        break;


                    case 2: //
                        sup = new SupportSkill();
                        sup.ApplyValues();
                        genrate_cartas();

                        //equip
                        break;

                    case 3: //
                        sup = new SupportSkill();
                        sup.ApplyValues();
                        genrate_cartas();


                        break;
                    case 4: //
                        sup = new SupportSkill();
                        sup.ApplyValues();
                        genrate_cartas();


                        break;
                    case 5: //
                        sup = new SupportSkill();
                        sup.ApplyValues();
                        genrate_cartas();


                        break;
                    case 6: //
                        sup = new SupportSkill();
                        sup.ApplyValues();
                        genrate_cartas();


                        break;
                    case 7://
                        equipo = new Equip();
                        equipo.ApplyValues();
                        genrate_cartas();
                        Console.WriteLine(equipo);

                        //equip
                        break;
                    case 8://
                        equipo = new Equip();
                        equipo.ApplyValues();
                        genrate_cartas();

                        //equip
                        break;
                    case 9:
                        personaje = new Character();
                        personaje.ApplyValues();
                        genrate_cartas();

                        //character
                        break;

                }
            }



            //imprimir

            void genrate_cartas()
            {
                double rareza;
                rareza = rnd.Next(0, 3);

                switch (rareza)
                {
                    case 0:
                        Rarety carta = Rarety.Common;

                        break;
                    case 1:
                        Rarety carta2 = Rarety.Rare;
                        break;
                    case 2:
                        Rarety carta3 = Rarety.SuperRare;
                        break;
                    case 3:
                        Rarety carta4 = Rarety.UltraRare;
                        break;

                }





            }



        }


       

    }
}
