using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace Taller_2
{
    [TestClass]
    public class UnitTest1
    {
        

       

        [TestMethod]
        public void cear_barajaDECK()
        {
            Deck baraja = new Deck();

            //si hay carta que es en la list
            int[] correc_case = { 1, 2, 3, 4, 5 };
            int[] incorret_case = { 6, 12, -1, -2 };

            for (int i = 0; i < correc_case.Length; i++)
            {
                Deck barajaChar = new Deck(correc_case[i]);

                Assert.IsTrue(barajaChar.deckChar.Count >= 5);
            }

            for (int i = 0; i < incorret_case.Length; i++)
            {
                Deck barajaChar = new Deck(incorret_case[i]);

                Assert.ThrowsException<Exception>(() => (barajaChar.deckChar.Count < 2));
            }



        }
        [TestMethod]
        public void crear_carta()
        {
            /*
            List<Character> deckChar = new List<Character>();
            var resultado = baraja;
            Assert.IsTrue();*/
            //llamar alas variables
            Deck baraja = new Deck();
            List<Character> deckChar = new List<Character>();
            List<Equip> deckEquip = new List<Equip>();
            List<SupportSkill> deckSkill = new List<SupportSkill>();

            int[] carater_person = { 1, 2, 3, 4, 5 };


            //ejecutar el problema
            for (int i = 0; i < carater_person.Length; i++)
            {
                if (i > deckChar.Count ||deckChar.Count< i)
                {
                   

                }
            
            }

            //revisar el problema

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
        public void Agragar_carta()
        {


        }
        [TestMethod]
        public void Batalla()
        {
            Player player =new Player();


        }

        [TestMethod]
        public void cartas_destruidas()
        {


        }
    }
}
