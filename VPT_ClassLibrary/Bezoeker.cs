using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Bezoeker
    {
        public string Naam { get; set; }
        public DateTime GeboorteDatum { get; set; }

        public bool IsGeplaatst = false;
        public int Leeftijd { get; set; }
        private readonly int _minimumLeeftijd = 12;
        public DateTime AanmeldDatum { get; set; }

        public Bezoeker(string naam, DateTime geboortedatum, DateTime aanmeldDatum)
        {
            Naam = naam;
            Leeftijd = GetAge(geboortedatum);
            IsGeplaatst = false;
            AanmeldDatum = aanmeldDatum;
        }

        public int GetAge(DateTime Geboortedatum)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (Geboortedatum.Year * 100 + Geboortedatum.Month) * 100 + Geboortedatum.Day;

            return (a - b) / 10000;
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

        public void TeLaatVoorEvenement()
        {
            Console.WriteLine("Helaas " + Naam + " u bent te laat, u kunt zich niet meer aanmelden voor dit evenement!\n");
        }
    }
}
