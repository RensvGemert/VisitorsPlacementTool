using System;
using System.Collections.Generic;
using System.Linq;
using DALFactories;
using DALInterfaces;
using Logic;

namespace UI
{
    class Program
    {
        private static readonly IBezoekerDAL _bezoekerDAL = BezoekerDALFactory.GetBezoekerDAL();

        static void Main(string[] args)
        {
            Organisatie organisatie = new Organisatie("Organisatie");
            List<Vak> vakken = organisatie.MaakVakken();

            Evenement evenement = new Evenement("Parcour Eindhoven", vakken, DateTime.Today.AddDays(-1));

            List<Bezoeker> bezoekers = _bezoekerDAL.GetAllBezoekers();
            List<Bezoeker> OpTijdAangemeldeBezoekers = evenement.FilterOpTijdAangemeldeBezoekers(bezoekers);
            List<Bezoeker> GesorteerdeBezoekers = evenement.SorteerBezoekers(OpTijdAangemeldeBezoekers);

            organisatie.GeefAangemeldeBezoekersEenId(GesorteerdeBezoekers);

            evenement.PlaatsBezoekers(GesorteerdeBezoekers, vakken);
            evenement.ToonEvenementOverzicht(vakken);
        }
    }
}
