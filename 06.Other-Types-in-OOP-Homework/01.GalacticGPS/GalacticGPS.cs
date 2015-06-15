namespace _01.GalacticGPS
{
    using System;

    public static class GalacticGps
    {
        public static void Main()
        {
            Location home = new Location(18.037986, 28.870097, Planet.Earth);
            Location researchLab = new Location(78.037986, -28.870097, Planet.Venus);
            Location villa = new Location(-8.037986, -178.870097, Planet.Neptune);

            Console.WriteLine("{0}\n{1}\n{2}", home, villa, researchLab);
        }
    }
}
