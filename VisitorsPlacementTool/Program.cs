using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
using DAL;
using Logic;
using LogicInterfaces;
using LogicFactories;

namespace UI
{
    class Program
    {
        private static readonly IBezoekerLogic _bezoekerLogic = BezoekerLogicFactory.GetBezoekerLogic();

        static void Main(string[] args)
        {
            List<Bezoeker> bezoekers = _bezoekerLogic.GetAllBezoekers();

            Organisatie organisatie = new Organisatie("Organisatie");

            List<Vak> vakken = organisatie.MaakVakken();

            Evenement evenement = new Evenement("Parcour Eindhoven", vakken);           
            evenement.RenderDetails();
            evenement.PlaatsBezoekers(bezoekers, vakken);
            evenement.ToonEvenementOverzicht(vakken);
        }
    }
}
