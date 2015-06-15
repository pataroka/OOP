namespace _01.GalacticGPS
{
    using System;
    using System.Security.AccessControl;

    public struct Location
    {
        private double latitude;

        private double longitude;

        public Location(double latidude, double longitude, Planet planet)
            : this()
        {
            this.Latitude = latidude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public double Latitude
        {
            get
            {
                return this.latitude;
            }

            set
            {
                if (value < -90.0 || value > 90.0)
                {
                    throw new ArgumentOutOfRangeException("value", "Value must be a floating point number in the range -90..90!");
                }

                this.latitude = value;
            }
        }

        public double Longitude
        {
            get
            {
                return this.longitude;
            }

            set
            {
                if (value < -180.0 || value > 180.0)
                {
                    throw new ArgumentOutOfRangeException("value", "Value must be a floating point number in the range -180..180!");
                }

                this.longitude = value;
            }
        }

        public Planet Planet { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}", this.Latitude, this.Longitude, this.Planet);
        }
    }
}