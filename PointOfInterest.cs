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
    }
}