using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Bezoeker
    {
        public string Naam { get; set; }
        public DateTime GeboorteDatum { get; set; }

        public bool IsGeplaatst = false;
        public int Leeftijd { get; set; }
        private readonly int _minimumLeeftijd = 12;

        public Bezoeker(string naam, DateTime geboorteDatum)
        {
            Naam = naam;
            GeboorteDatum = geboorteDatum;
            IsGeplaatst = false;
        }

        public bool IsKind()
        {
            if (Leeftijd <= _minimumLeeftijd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetAge(DateTime Geboortedatum)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (Geboortedatum.Year * 100 + Geboortedatum.Month) * 100 + Geboortedatum.Day;

            return (a - b) / 10000;
        }
    }
}
