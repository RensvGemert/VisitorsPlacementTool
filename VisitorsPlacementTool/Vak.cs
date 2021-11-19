using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorsPlacementTool
{
    public class Vak
    {
        public string VakLetter { get; set; }
        public List<Rij> rijen = new List<Rij>();
        public int TotaalAantalStoelen;
        public int AantalBezoekersInDitVak { get; set; }

        public Vak()
        {

        }

        public Vak(string vakLetter, int aantalRijen, int aantalStoelenPerRij)
        {
            VakLetter = vakLetter;
            MaakRijen(aantalRijen, aantalStoelenPerRij);
            BerekenAantalStoelenPerVak(aantalRijen, aantalStoelenPerRij);
        }

        public int BerekenAantalStoelenPerVak(int aantalRijen, int aantalStoelenPerRij)
        {
            TotaalAantalStoelen = aantalRijen * aantalStoelenPerRij;
            return TotaalAantalStoelen;
        }

        public void MaakRijen(int aantalRijen, int aantalStoelenPerRij)
        {
            // Als aantal rijen groter of gelijk is aan 1 EN kleiner of gelijk is aan 3
            if (aantalRijen >= 1 && aantalRijen <= 3)
            {
                for (int i = 1; i <= aantalRijen; i++)
                {
                    // Als aantal stoelen op rij groter of gelijk is aan 3 EN kleiner of gelijk is aan 10
                    if (aantalStoelenPerRij >= 3 && aantalStoelenPerRij <= 10)
                    {
                        List<Stoel> stoelen = new List<Stoel>();
                        for (int x = 1; x <= aantalStoelenPerRij; x++)
                        {
                            Stoel stoel = new Stoel(VakLetter + i + "-" + x);
                            stoelen.Add(stoel);
                        }
                        rijen.Add(new Rij(i, stoelen));
                    }                  
                }
            }
            else
            {
                throw new InvalidOperationException("Vak te groot!");
            }
           
        }

        public bool PlaatsBezoeker(Bezoeker bezoeker)
        {
            if (bezoeker.IsGeplaatst == true)
            {
                return false;
            }
            foreach (var rij in rijen)
            {           
                if (rij.IsErPlek() == true)
                {
                    rij.PlaatsBezoeker(bezoeker);
                    AantalBezoekersInDitVak++;
                    return true;
                }
                // check volgende rij 
            }
            return false;
        }
    }
}
