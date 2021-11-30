using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
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
            return Vakken;
        }
    }
}
