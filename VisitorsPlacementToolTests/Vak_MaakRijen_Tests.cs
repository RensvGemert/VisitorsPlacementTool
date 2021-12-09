using Microsoft.VisualStudio.TestTools.UnitTesting;
using UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace UI.Tests
{
    [TestClass()]
    public class Vak_MaakRijen_Tests
    {
        [TestMethod()]
        public void Maak_Rijen_Test_Aantal_AreEqual()
        {
            Vak vak = new Vak();
            vak.MaakRijen(2, 5);

            int VerwachtResultaat = 2;
            int Resultaat = vak.rijen.Count;
            
            Assert.AreEqual(VerwachtResultaat, Resultaat);
        }

        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Maak_Te_Veel_Rijen_Test_ThrowException()
        {
            Vak vak = new Vak();
            vak.MaakRijen(53, 5);
        }
    }
}