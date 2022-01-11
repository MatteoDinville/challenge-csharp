using System;

namespace CSharpDiscovery.Quest03
{
    public class PointOfInterest
    {
        public double Latitude;
        public double Longitude;
        public double Name;
        public static string GoogleMapsUrlTemplate = "https://www.google.com/maps/place/{0}/@{1},{2},15z/";

    }
}