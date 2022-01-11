using System;

namespace CSharpDiscovery.Quest03
{
    public class HistoricalMonument : PointOfInterest
    {
        public int BuildYear{ get; set; }

        public HistoricalMonument() { }

        public HistoricalMonument(string Name, double Lat, double Long,  int Build) : base(Name, Lat, Long)
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