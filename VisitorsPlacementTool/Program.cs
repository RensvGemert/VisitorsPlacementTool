using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
using VisitorsPlacementDAL;
using VisitorsPlacementLogic;

namespace UI
{
    class Program
    {
        private static BezoekerLogic _bezoekerLogic = new BezoekerLogic(new BezoekerDAL());

        static void Main(string[] args)
        {
            // Maak bezoekers
            //MaakBezoekerTestData();
            List<Bezoeker> bezoekers = _bezoekerLogic.MaakBezoekerTestData();

            // Maak vakken:
            List<Vak> vakken = MaakVakken();

            // Maak evenement:
            Evenement evenement = new Evenement("Parcour Eindhoven", vakken);           
            evenement.RenderDetails();

            // Plaatsbezoekers:
            evenement.PlaatsBezoekers(bezoekers, vakken);

            // UI
            RenderUI(vakken);
        }

        private static List<Vak> MaakVakken()
        {
            List<Vak> Vakken = new List<Vak>();
            Vak vakA = new Vak("A", 3, 3);
            Vak vakB = new Vak("B", 3, 3);
            Vak vakC = new Vak("C", 3, 3);

            Vakken.Add(vakA);
            Vakken.Add(vakB);
            Vakken.Add(vakC);
            return Vakken;
        }

        private static void RenderUI(List<Vak> vakken)
        {
            foreach (var vak in vakken)
            {
                Console.WriteLine("Vak: " + vak.VakLetter);
                foreach (var rij in vak.rijen)
                {
                    foreach (var stoel in rij.Stoelen)
                    {
                        if (stoel.Bezoeker != null)
                        {
                            Console.WriteLine(stoel.StoelCode + " " + stoel.Bezoeker.Naam);
                        }
                        else
                        {
                            Console.WriteLine(stoel.StoelCode);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
