using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Taller_2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void crear_carta()
        {
            
            //crear carta con un buleano
            


        }

        [TestMethod]
        public void crear_jugador()
        {

        }

        [TestMethod]
        public void cear_barajaDECK()
        {
            Deck baraja = new Deck();

            //si hay carta que es en la list
            int[] correc_case = { 0, 1, 2, 3, 4, 5 };
            int[] incorret_case = { 6, 12, -1, -2 };

            for (int i = 0; i < correc_case.Length; i++)
            {
                Deck barajaChar = new Deck(correc_case[i]);

                Assert.IsTrue(barajaChar.deckChar.Count >= 5);
            }

            for (int i = 0; i < incorret_case.Length; i++)
            {
                Deck barajaChar = new Deck(incorret_case[i]);

                Assert.ThrowsException<Exception>(() => (barajaChar.deckChar.Count < 5));
            }



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
