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
            Organisatie organisatie = new Organisatie("Organisatie");
            List<Vak> vakken = organisatie.MaakVakken();

            Evenement evenement = new Evenement("Parcour Eindhoven", vakken, DateTime.Today.AddDays(-1));
            evenement.RenderDetails();

            List<Bezoeker> bezoekers = _bezoekerLogic.GetAllBezoekers();
            List<Bezoeker> OpTijdAangemeldeBezoekers = evenement.FilterOpTijdAangemeldeBezoekers(bezoekers);
            List<Bezoeker> GesorteerdeBezoekers = evenement.SorteerBezoekersOpAanmeldDatum(OpTijdAangemeldeBezoekers);

            evenement.PlaatsBezoekers(GesorteerdeBezoekers, vakken);
            evenement.ToonEvenementOverzicht(vakken); 
        }
    }
}
