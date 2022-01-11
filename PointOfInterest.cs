using System;

namespace CSharpDiscovery.Quest03
{
    public class PointOfInterest
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Name { get; set; }
        public static string GoogleMapsUrlTemplate { get; set; } = "https://www.google.com/maps/place/{0}/@{1},{2},15z/";

        public PointOfInterest()
        {
            this.Name = "Bordeaux Ynov Campus";
            this.Latitude = 44.854186;
            this.Longitude = -0.5663056;
        }

        public PointOfInterest(string Name, double Latitude, double Longitude)
        {
            this.Name = Name;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
        }
        public string GetGoogleMapsUrl()
        {
            string result = PointOfInterest.GoogleMapsUrlTemplate;
            result = result.Replace("{0}", this.Name.Replace(' ', '+'));
            result = result.Replace("{1}", this.Latitude.ToString());
            result = result.Replace("{2}", this.Longitude.ToString());
            return result;
        }
        public override string ToString()
        {
            string resultTemplate = "{0} (Lat={1}, Long={2})";
                return string.Format(resultTemplate, this.Name, this.Latitude, this.Longitude);
        }

        private static double GetDistancePriv(double longitude, double latitude, double otherLongitude, double otherLatitude)
        {
            var d1 = latitude * (Math.PI / 180.0);
            var num1 = longitude * (Math.PI / 180.0);
            var d2 = otherLatitude * (Math.PI / 180.0);
            var num2 = otherLongitude * (Math.PI / 180.0) - num1;
            var d3 = Math.Pow(Math.Sin((d2 - d1) / 2.0), 2.0) + Math.Cos(d1) * Math.Cos(d2) * Math.Pow(Math.Sin(num2 / 2.0), 2.0);

            return 6376500.0 * (2.0 * Math.Atan2(Math.Sqrt(d3), Math.Sqrt(1.0 - d3)));
        }

        public int GetDistance(PointOfInterest other)
        {
            return (int)Math.Round(GetDistancePriv(this.Longitude, this.Latitude, other.Longitude, other.Latitude) * 0.001);
        }

        public static int GetDistance(PointOfInterest p1, PointOfInterest p2)
        {
            return (int)Math.Round(GetDistancePriv(p1.Longitude, p1.Latitude, p2.Longitude, p2.Latitude) * 0.001);
        }
    }
}