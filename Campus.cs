using System;

namespace CSharpDiscovery.Quest03
{
    public class Campus : PointOfInterest
    {
        public int Capacity 
        {
            get; set;
        }
    public override string ToString()
    {
        string Template = "{0} is a campus with a capacity of {1} students";
        return string.Format(Template, this.Name, Capacity);
    }
    }
}