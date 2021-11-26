using Microsoft.VisualStudio.TestTools.UnitTesting;
using UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace UI.Tests
{
    [TestClass()]
    public class Evenement_Tests
    {
        [TestMethod()]
        public void BerekenMaxAantalBezoekersTest_AreEqual()
        {
            List<Vak> vakken = new List<Vak>();
            Vak vakA = new Vak("A", 3, 5);
            Vak vakB = new Vak("B", 3, 5);
            vakken.Add(vakA);
            vakken.Add(vakB);

            Evenement evenement = new Evenement("Parcour Eindhoven", vakken);
            int verwachtResultaat = 30;
            int resultaat = evenement.BerekenMaxAantalBezoekers(vakken);

            Assert.AreEqual(verwachtResultaat, resultaat);
        }

        [TestMethod()]
        public void BerekenMaxAantalBezoekersTest_AreNotEqual()
        {
            List<Vak> vakken = new List<Vak>();
            Vak vakA = new Vak("A", 3, 5);
            Vak vakB = new Vak("B", 1, 4);
            vakken.Add(vakA);
            vakken.Add(vakB);

            Evenement evenement = new Evenement("Parcour Eindhoven", vakken);
            int foutResultaat = 1;
            int resultaat = evenement.BerekenMaxAantalBezoekers(vakken);

            Assert.AreNotEqual(foutResultaat, resultaat);
        }

        [TestMethod()]
        public void PlaatsBezoekersTest_AreEqual()
        {
            List<Bezoeker> bezoekers = new List<Bezoeker>();
            bezoekers.Add(new Bezoeker("TestBezoeker01", 21));
            bezoekers.Add(new Bezoeker("TestBezoeker02", 22));

            List<Vak> vakken = new List<Vak>();
            Vak VakA = new Vak("A", 1, 5);
            Vak VakB = new Vak("B", 1, 5);
            Vak VakC = new Vak("C", 1, 5);
            vakken.Add(VakA);
            vakken.Add(VakB);
            vakken.Add(VakC);


            Evenement evenement = new Evenement("TestEvenement", vakken);
            evenement.PlaatsBezoekers(bezoekers, vakken);

            int resultaat = VakA.AantalBezoekersInDitVak;
            int verwachtresultaat = 2;

            Assert.AreEqual(verwachtresultaat, resultaat);
        }

        [TestMethod()]
        public void PlaatsBezoekersTest_AreNotEqual()
        {
            List<Bezoeker> bezoekers = new List<Bezoeker>();
            bezoekers.Add(new Bezoeker("TestBezoeker01", 21));
            bezoekers.Add(new Bezoeker("TestBezoeker02", 22));

            List<Vak> vakken = new List<Vak>();
            Vak VakA = new Vak("A", 1, 5);
            Vak VakB = new Vak("B", 1, 5);
            Vak VakC = new Vak("C", 1, 5);
            vakken.Add(VakA);
            vakken.Add(VakB);
            vakken.Add(VakC);


            Evenement evenement = new Evenement("TestEvenement", vakken);
            evenement.PlaatsBezoekers(bezoekers, vakken);

            int resultaat = VakA.AantalBezoekersInDitVak;
            int verwachtresultaat = 1;

            Assert.AreNotEqual(verwachtresultaat, resultaat);
        }

    }
}