using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Organisatie
    {
        public string OrganisatieNaam { get; set; }

        public Organisatie(string organisatieNaam)
        {
            OrganisatieNaam = organisatieNaam;
        }

        public List<Vak> MaakVakken()
        {
            List<Vak> Vakken = new List<Vak>();
            Vakken.Add(new Vak("A", 3, 3));
            Vakken.Add(new Vak("B", 1, 3));
            Vakken.Add(new Vak("C", 3, 3));
            Vakken.Add(new Vak("D", 3, 3));
            return Vakken;
        }

        public void GeefAangemeldeBezoekersEenId(List<Bezoeker> bezoekers)
        {
            int id = 0;
            for (int i = 0; i < bezoekers.Count; i++)
            {
                id += 1;
                bezoekers[i].Id += id;
            }
        }

    }
}
