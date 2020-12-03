using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetMission
{
    class PlanetMission
    {
        public long RocketFuelPerMile;
        public long RocketSpeedMPH;
        public int MilesToPlanet;
        public long UnitsOfFuelNeeded()
        {
            return MilesToPlanet * RocketFuelPerMile;
        }
        public int TimeNeeded()
        {
          return MilesToPlanet / (int)RocketSpeedMPH;
        }
        public string FuelNeeded()
        {
            return "Będziesz potrzebować " + MilesToPlanet * RocketFuelPerMile + " Jednostek paliwa żeby tam się dostać. Zajmie ci to " + TimeNeeded() + " godzin.";
        }
    }
}
