using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void crear_carta()
        {
            

            //vectores 
        }

        [TestMethod]
        public void crear_jugador()
        {

        }

        [TestMethod]
        public void cear_barajaDECK()
        {
            Deck baraja = new Deck();

            //si hay carta que es en la lista
            if (deckchar.contains(5))
            {
                Assert.IsTrue(deckchar > 5);

            }
            if (deckEquip.contains(5))
            {
                Assert.IsTrue(deckEquip > 10);

            }
            if (deckSkill.contains(5))
            {
                Assert.IsTrue(deckSkill > 5);

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
