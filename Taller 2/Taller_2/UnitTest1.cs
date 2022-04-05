using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace Taller_2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Agragar_carta()
        {

            //lo que nesesito: no pasar el limites de cp
            Deck baraja = new Deck();
            Card carta = new Card();

            List<Character> deckChar = new List<Character>();
            List<Equip> deckEquip = new List<Equip>();
            List<SupportSkill> deckSkill = new List<SupportSkill>();
            
            int=
            
            //la ejecucion
            if () 
            {

            }

            //resultado
            Assert.AreEqua();
        }

        [TestMethod]
        public void cear_barajaDECK()
        {
            Deck baraja = new Deck();

            
            List<Character> deckChar = new List<Character>();
            List<Equip> deckEquip = new List<Equip>();
            List<SupportSkill> deckSkill = new List<SupportSkill>();

            int pers_confir = 5;
            int pers_confir2 = 10;

            int contador1 = 0;
            int contador2 = 0;
            int contador3 = 0;
            //ejecutar el problema
            for (int i = 0; i < deckChar.Count; i++)
            {
                contador1++;
            }
            //revisar el problema
            Assert.IsTrue(pers_confir <= contador1);//juanfer ayuda

            for (int i = 0; i < deckEquip.Count; i++)
            {
                contador2++;
            }
            //revisar el problema
            Assert.IsTrue(pers_confir2 <= contador2);//juanfer ayuda

            for (int i = 0; i < deckSkill.Count; i++)
            {
                contador3++;
            }
            //revisar el problema
            Assert.IsTrue(pers_confir <= contador3);//juanfer ayuda




        }
        
        [TestMethod]
        public void Batalla()
        {
            Player player = new Player();


        }

        [TestMethod]
        public void prueva_Character()
        {


        }

        [TestMethod]
        public void prueva_Equip()
        {

        }

        [TestMethod]
        public void prueva_SupportSkill()
        {

        }


        [TestMethod]
        public void cartas_destruidas()
        {


        }
    }
}
