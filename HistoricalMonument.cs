using System;

namespace CSharpDiscovery.Quest03
{
    public class HistoricalMonument : PointOfInterest
    {
        public int BuildYear{ get; set; }

        public HistoricalMonument() { }

        public HistoricalMonument(double Lat, double Long, string Name, int Build) : base(Lat, Long, Name)
        {
            this.BuildYear = Build;
        }
        public override string ToString()
        {
            string Template = "{0} is a historical monument built in {1}";
            return string.Format(Template, this.Name, this.BuildYear);
        }
    }
}